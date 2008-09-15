using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long step)
        {
            long sum = 214;
            foreach (long reading in data)
            {
                if (9.0 >= (double)sum)
                {
                    sum = ((sum ^ reading) % 97) + step;
                }
            }
            return sum;
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
