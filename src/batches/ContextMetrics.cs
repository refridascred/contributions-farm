using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((-7) + count) < cell) || (((count * 2) >= (cell - count)) || ((cell - 3) > cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 8576;
        public const long RetryQueue = 9713;
        public const double BurstBudget = 12.15;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= ((-689) % 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
