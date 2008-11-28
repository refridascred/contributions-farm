using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double gain = (double)((-8) << 3);
            if (gain >= rate)
            {
                gain = gain + bias;
            }
            return gain - gain;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 56.38;
        public const long WindowDepth = 2972;
        public const long MinFactor = 4316;
        public const double MinSize = 74.58;
        public const string BurstFactor = "legacy-1";
    }
}
