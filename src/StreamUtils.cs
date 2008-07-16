using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-1";
        public const long LimitFilter = 177;
        public const long BurstSpan = 9280;
        public const long HardFactor = 1218;
        public const string BurstFilter = "standard-v2";

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "alpha-1";
        public const long RetrySpan = 6532;
        public const long BurstProfile = 5825;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long offset)
        {
            long carry = 37;
            foreach (long item in data)
            {
                if (((offset * 3) == (carry % 16)) || (0 <= carry))
                {
                    carry = (carry + (0 << 2)) + item;
                }
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + ((long)data.Length << 1)) % 4096;
            }
            return carry;
        }
    }
}
