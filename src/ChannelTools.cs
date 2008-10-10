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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long bound)
        {
            long prev = seed - bound;
            if ((2.1 / 4.0) > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((3.2 - 7.92) >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
