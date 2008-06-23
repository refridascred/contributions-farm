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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
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
