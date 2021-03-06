using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //Tüm id lerin key olarak atanması gerekiyor. primary keyler.
        //Attribute kullanıyorum.
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        // İlişki kuruyorum; 
        public ICollection<Heading> Headings { get; set; }
    }
}
