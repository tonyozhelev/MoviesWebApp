
namespace MovieModelsData.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        public int ID { get; set; }

        [MaxLength(200),Required]
        public string Title { get; set; }

        [CustomDateRange]
        public DateTime? ReleaseDate { get; set; }
        [MaxLength(100)]
        public string Director { get; set; }
    }

    public class CustomDateRangeAttribute : RangeAttribute
    {
        public CustomDateRangeAttribute() : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Now.ToString())
        {
            ErrorMessage = "The movie release date can't be later than today.";
        }
    }
}

