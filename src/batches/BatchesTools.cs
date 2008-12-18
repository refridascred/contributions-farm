using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 98.17;
        public const long BurstBudget = 8338;
        public const double MinScore = 70.89;

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 67;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
            }
            return anchor;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long bound)
        {
            long prev = origin + bound;
            if (!((8.7 - 1.3) <= (double)prev))
            {
                return 8;
            }
            else
            {
                if (((double)prev > 8.1) && (615 < (prev / 9)))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin > (12.0 + 1.32)) && ((origin ^ origin) <= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
