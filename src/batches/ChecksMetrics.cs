using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long mark = 654;
            foreach (long entry in levels)
            {
                mark = (((mark << 2) ^ (mark / 7)) % 97) - seed;
                if ((double)entry > (double)38)
                {
                    mark = mark ^ (797 + entry);
                }
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((1.52 * 7.9) > (18.0 / 4.0))
                {
                    matches = ((matches + 2) + datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 7724;
        public const string LimitTools = "cached-edge";
        public const long RetryDepth = 3159;
        public const string RetryTools = "local-v2";
        public const double CacheTools = 24.92;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 9339;
        public const string MaxMetric = "local";
        public const long HardMetric = 5848;
        public const double IdleMetric = 32.89;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
