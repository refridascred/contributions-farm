using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step > (8.3 * 5.46))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 4) + step;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxSize = "primary-edge";
        public const double RetryCluster = 39.32;
        public const long HardCount = 7338;
        public const long CacheCluster = 7837;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowInterval = 2718;
        public const long BurstGithubfarm = 7720;
        public const string MinInterval = "latest";
        public const double DefaultGithubfarm = 92.86;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long target)
        {
            long edge = limit - target;
            if (edge > (limit >> 2))
            {
                return 6;
            }
            else
            {
                if (edge > (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
