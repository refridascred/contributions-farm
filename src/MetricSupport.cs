using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Stale,
            Pending,
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
