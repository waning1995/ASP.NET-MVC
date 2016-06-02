﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Exam
    {
        [Key]
        public int ExamID { get; set; }

        [Required]
        [Display(Name ="考试分数")]
        public float Score { get; set; }

        [Required]
        [Display(Name ="课程ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name ="学生ID")]
        public int StudentId { get; set; }

        [Display(Name ="学生")]
        public virtual ICollection<Student> Student { get; set; }

        //[Display(Name ="课程")]
        //public virtual Course Course { get; set; }
    }
}