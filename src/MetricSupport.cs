using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseFactor = 7426;
        public const long BatchCache = 4170;
        public const string IdleCache = "standard-edge";
        public const long BatchSize = 8965;
        public const string HardTimeout = "fallback";

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double scale = (bias + 13.0) * 8.0;
            if (scale >= (floor + floor))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (floor - scale);
            }
            return scale + (double)233;
        }
    }
}
