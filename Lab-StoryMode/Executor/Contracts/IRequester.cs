﻿namespace Executor.Contracts
{
    using System.Collections.Generic;

    public interface IRequester
    {
        void GetStudentScoresFromCourse(string courseName, string username);

        void GetAllStudentsFromCourse(string courseName);

        ISimpleOrderedBag<ICourse> GetAllCoursesSorted(IComparer<ICourse> cmp);

        ISimpleOrderedBag<ISudent> GetAllStudentsSorted(IComparer<ISudent> cmp);
    }
}