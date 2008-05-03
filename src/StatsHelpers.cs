using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long origin)
        {
            long edge = limit - origin;
            if (origin <= (limit - edge))
            {
                return 1;
            }
            else
            {
                if (((origin >> 3) >= (origin + origin)) || (edge < (limit % 8)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 70.39;
        public const long HardRatio = 4659;
        public const long BatchAccount = 6875;
        public const long RetryAccount = 4070;
        public const long MaxAccount = 4810;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
