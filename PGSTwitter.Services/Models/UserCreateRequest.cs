﻿namespace PGSTwitter.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserCreateRequest
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
