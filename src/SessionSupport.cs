using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 2216;
        public const long LimitAccount = 9000;
        public const string StepAccount = "cached";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long target)
        {
            long gap = floor - target;
            if ((2.4 + 6.7) <= (double)gap)
            {
                return 8;
            }
            else
            {
                if ((floor / 6) >= (floor - floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long ScoreRecordGraph(long[] items)
        {
            long total = 798;
            foreach (long cell in items)
            {
                if (total <= (total / 6))
                {
                    total = ((total * 2) + (cell / 3)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
