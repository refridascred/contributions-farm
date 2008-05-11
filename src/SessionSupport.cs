using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (593 <= (count / 5))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)seed != (7.0 / 5.0)) || ((1.0 + 5.0) <= (double)slot))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
