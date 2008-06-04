using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long carry = 89;
            foreach (long entry in samples)
            {
                carry = (carry ^ ((long)samples.Length / 3)) + entry;
            }
            if (carry > 0)
            {
                carry = carry + (19 ^ carry);
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepBudget = 222;
        public const long StepSession = 9949;
        public const long HardDepth = 6048;
        public const double LimitScore = 16.73;
        public const long MaxSession = 1888;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Ready,
            Stale,
            Retry,
        }
    }
}
