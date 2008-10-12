using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches >= (origin - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7498;
        public const string MinInterval = "stable-1";
        public const double HardToken = 72.44;
        public const double SoftTimeout = 57.1;
        public const string CacheToken = "open";

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long bound2)
        {
            if (!((bound % 24) >= (66 & 63)))
            {
                return 1;
            }
            else
            {
                if (bound2 >= (bound2 / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ anchor) ^ reading;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }
    }
}
