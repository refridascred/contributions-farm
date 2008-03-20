using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 72;
        public const long WindowScore = 8431;
        public const string BurstSession = "staging-edge";
        public const long StepSession = 7451;
        public const string RetryWidth = "alpha-edge";
    }
}
