using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double offset)
        {
            double gain = 7.46;
            if (gain > (double)(-9))
            {
                gain = (gain + (8.43 + gain)) - offset;
            }
            return gain + weight;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Queued,
            Stale,
            Failed,
            Pending,
        }
    }
}
