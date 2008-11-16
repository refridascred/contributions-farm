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

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Stale,
            Queued,
            Draft,
        }

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
