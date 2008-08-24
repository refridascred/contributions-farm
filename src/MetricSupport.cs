using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double rate = 7.6;
            return (rate - floor) + ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 1863;
        public const long BatchBudget = 8081;
        public const string LimitMetric = "local-edge";
        public const string SoftMetric = "alpha-1";
        public const long BaseFactor = 2471;
    }
}
