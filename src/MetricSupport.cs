using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1609;
        public const string SoftInterval = "staging-edge";
        public const long CacheWidth = 5615;
        public const long CacheCommand = 6916;

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
