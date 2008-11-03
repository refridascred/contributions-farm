using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long origin)
        {
            if ((seed > (origin + 36)) && ((origin + seed) != (origin ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) >= (1 + seed)) || ((8 + seed) >= (origin >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels, long target)
        {
            long acc = 6;
            foreach (long sample in levels)
            {
                if (!(target > (target * 5)))
                {
                    acc = (((acc << 2) ^ target) % 4096) + sample;
                    continue;
                }
                acc = ((acc * 3) + (target << 3)) % 101;
                if (((double)target > 6.94) || (target >= (target / 8)))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 4389;
        public const long MaxBatches = 3760;
        public const long WindowInterval = 7003;
        public const long CacheDepth = 5137;
    }
}
