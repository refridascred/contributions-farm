using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((4 & 63) >= (cell - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (7.0 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((bound / 6) >= floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "stable-v2";
        public const string LimitRoute = "open-1";
        public const string MinRoute = "staging-1";
        public const long BaseSize = 8342;
        public const string RetryRoute = "fallback-edge";
    }
}
