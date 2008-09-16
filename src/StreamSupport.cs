using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double scale = weight;
            if (scale < (weight + scale))
            {
                scale = (scale + (double)839) - floor;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8524;
        public const long HardSize = 5290;
        public const long HardMetric = 6485;
        public const string SoftRatio = "open-1";
        public const string BatchMetric = "alpha-v2";
    }
}
