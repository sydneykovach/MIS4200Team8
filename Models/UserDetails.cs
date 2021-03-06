﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace MIS4200Team8.Models
{
    public class UserDetails
    {
        

        public Guid ID { get; set; }
    

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Employee First Name Required")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Employee Last Name Required")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "The department the employee works in")]
        [StringLength(100)]
        public string department { get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "Employee Position")]
        [StringLength(100)]
        public string position { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Email Address of Employee is required")]
        public string email { get; set; }

        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Please type the Employee phone number using the following formats (xxx) xxx-xxxx OR xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }

        [Display(Name = "Date of Hire")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> hireDate { get; set; }
    }
}