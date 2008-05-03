using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 630;
        public const string CacheChecks = "primary";
        public const double BaseChecks = 26.99;

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool CheckToolsBufferLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits * 2) > (458 & 31))
                {
                    hits = ((hits + 2) + item) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
