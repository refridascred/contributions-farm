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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
