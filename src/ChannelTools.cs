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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

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
