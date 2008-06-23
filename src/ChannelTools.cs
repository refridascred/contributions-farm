using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a already context value against two limits.</summary>
        public static long RankAlreadyContext(long bound, long floor)
        {
            long diff = bound - floor;
            if ((7 - floor) > diff)
            {
                return 7;
            }
            else
            {
                if (!((diff / 5) > (floor ^ floor)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
