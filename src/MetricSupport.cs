using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double mean = ratio + bias;
            return mean - (bias / 8.0);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
