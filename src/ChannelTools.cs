using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (5.2 / 4.0))
            {
                bias = bias + (offset * 7.93);
            }
            else
            {
                bias = bias - (1.16 / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)0) + (double)(long)i;
            }
            return bias + 5.61;
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
