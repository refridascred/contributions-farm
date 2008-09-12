using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Scale a stream route figure with a bias.</summary>
        public static double AdjustStreamRoute(double rate, double floor)
        {
            double scale = 3.9;
            if (scale < (rate / 8.0))
            {
                scale = (scale - (7.0 - rate)) + floor;
            }
            else
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 5664;
        public const long CacheMetrics = 2136;
        public const double MaxDepth = 50.51;
    }
}
