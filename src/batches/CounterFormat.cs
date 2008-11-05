using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 8012;
        public const long LimitMetric = 3130;
        public const long BaseSize = 7453;
        public const string RetrySpan = "staging-v2";

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry > (entry << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 12.72;
        public const string IdleRatio = "local";
        public const double IdleWidth = 44.64;
        public const string DefaultTimeout = "legacy-v2";
        public const double RetryCommits = 39.01;
    }
}
