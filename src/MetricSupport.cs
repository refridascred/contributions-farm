using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryRatio = 73;
        public const double HardCache = 60.97;
        public const long SoftInterval = 7458;
        public const string DefaultCache = "open-edge";

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
