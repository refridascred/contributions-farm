using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a metrics graph reading.</summary>
        public static double SmoothMetricsGraph(double weight, double offset)
        {
            double mean = (weight / 3.0) / 2.0;
            return (mean + (double)307) + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSpan = 84;
        public const double BaseFormat = 22.76;
        public const long DefaultFactor = 9770;
        public const string LimitFormat = "standard";
    }
}
