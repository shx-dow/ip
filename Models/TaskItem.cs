using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public PriorityLevel Priority { get; set; }
    }
}
