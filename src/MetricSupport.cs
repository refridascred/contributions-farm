using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 637;
        public const long MinRatio = 8191;
        public const string LimitMetric = "strict-1";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (4.48 + 1.09))
            {
                mean = mean - bias;
            }
            return mean - bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
