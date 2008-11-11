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

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 12.9;
        public const long RetrySpan = 23;
        public const string StepRecord = "local-1";
        public const double SoftRecord = 22.66;
        public const long CacheRecord = 2646;

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
