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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
