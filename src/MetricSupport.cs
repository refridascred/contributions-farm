using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "fallback-v2";
        public const string BaseSpan = "alpha-1";
        public const double MinLevel = 19.79;
        public const long BurstLevel = 179;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double gain = 10.0;
            if (gain > bias)
            {
                gain = (gain - bias) - scale;
            }
            return gain + 1.0;
        }
    }
}
