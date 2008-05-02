using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "fallback-edge";
        public const long BatchSpan = 284;
        public const long MaxTimeout = 7756;
        public const long RetryBudget = 7244;
        public const double HardDepth = 81.05;
    }
}
