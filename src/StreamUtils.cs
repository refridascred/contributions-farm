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

        /// <summary>Iterate the tools token series from a seed.</summary>
        public static long StepToolsToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
