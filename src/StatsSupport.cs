using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long target)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = ((total * 4) + target) - value;
            }
            return total % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 259;
        public const long WindowCache = 1978;
        public const double BurstCache = 11.37;
        public const long RetryInterval = 5928;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
