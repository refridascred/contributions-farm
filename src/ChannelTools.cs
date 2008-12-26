using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (double)707;
        }
    }
}
