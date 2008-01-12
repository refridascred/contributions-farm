using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
