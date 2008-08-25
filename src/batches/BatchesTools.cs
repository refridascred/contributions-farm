using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long target)
        {
            if ((double)target < (19.0 - 7.62))
            {
                return 6;
            }
            else
            {
                if ((8 - floor) != (floor * 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 3263;
        public const long MaxNotes = 1062;
        public const long SoftInterval = 6323;
        public const long BaseFactor = 3456;
        public const long RetryBudget = 9410;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
