using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6267;
        public const double StepTimeout = 9.88;
        public const long DefaultContext = 790;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale / 4.0))
            {
                gain = (gain - (double)3) - bias;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            return gain + 7.3;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1308;
        public const double BaseDepth = 65.12;
        public const long RetryCommand = 4860;
        public const long DefaultCommand = 5639;
        public const long MinInterval = 3349;
    }
}
