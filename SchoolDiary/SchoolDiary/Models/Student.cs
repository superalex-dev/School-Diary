using System;
using System.Collections.Generic;

namespace SchoolDiary.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
        }

        public int Id { get; set; }
        public string StudentName { get; set; } = null!;
        public string StudentClass { get; set; } = null!;

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
