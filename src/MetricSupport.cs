using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchSpan = 6.13;
        public const string IdleWindow = "standard-1";
        public const long DefaultWidth = 2498;
        public const double HardRatio = 73.19;

        /// <summary>Adjust a token batch reading.</summary>
        public static double ScaleTokenBatch(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale * 14.0))
            {
                rate = (rate + (scale - scale)) + span;
            }
            return rate + (3.8 * 15.0);
        }
    }
}
