using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "primary-edge";
        public const long CacheBudget = 6833;
        public const double SoftInterval = 68.8;
        public const string RetryMetric = "standard-v2";
        public const string LimitMetric = "legacy-edge";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double bias2 = scale * 5.0;
            if (bias2 > (14.0 - bias))
            {
                bias2 = bias2 - scale;
            }
            return bias2 + bias2;
        }
    }
}
