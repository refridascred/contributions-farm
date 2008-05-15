using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "open-edge";
        public const string MaxLevel = "staging";
        public const long SoftScore = 2401;
        public const long SoftCount = 217;
        public const long RetryCount = 3845;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Synced,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long DeriveFilterOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i <= target)
                {
                    acc = (acc + target) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
