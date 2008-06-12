using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double gain = (rate / 8.0) + (rate - span);
            return gain - gain;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 57.97;
        public const long BaseStream = 4598;
        public const long StepStream = 4639;
        public const string SoftStream = "local-1";
        public const long SoftDepth = 9196;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
