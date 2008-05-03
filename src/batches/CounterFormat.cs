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

        /// <summary>Find the first payload notes entry that matches the target.</summary>
        public static long FindPayloadNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
