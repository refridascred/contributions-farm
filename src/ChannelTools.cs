using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a support stats pair into a bucket.</summary>
        public static long RankSupportStats(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap < 9.43)
            {
                return 7;
            }
            else
            {
                if ((gap - origin) <= (origin + 4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
