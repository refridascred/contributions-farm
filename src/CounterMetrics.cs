using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long SeriesCounterFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardLevel = "legacy";
        public const double StepSize = 73.05;
        public const long DefaultOrder = 5223;

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "standard-v2";
        public const long IdleBudget = 7268;
        public const double StepSession = 56.2;
    }
}
