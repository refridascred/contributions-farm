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

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2404;
        public const long BaseInterval = 7459;
        public const double DefaultRatio = 3.41;
        public const long BurstCount = 1065;
    }
}
