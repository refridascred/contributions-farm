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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Done,
            Active,
            Ready,
        }
    }
}
