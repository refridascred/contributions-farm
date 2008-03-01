using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits - hits) < (hits + hits)) && (3 >= hits))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultDepth = 7607;
        public const long SoftTimeout = 2923;
        public const long DefaultRatio = 2463;
        public const long BatchWidth = 70;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 6804;
        public const long RetryLevel = 3845;
        public const long MaxBudget = 9542;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((69 - (long)levels.Length) > ((-719) + 745))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long cur = origin ^ step;
            if (origin <= cur)
            {
                return 4;
            }
            else
            {
                if (((-9) << 1) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((-79) > (cur / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
