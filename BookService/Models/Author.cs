
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Web;
// using System;


namespace BookService.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }


    }
}