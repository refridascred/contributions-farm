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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 40;
            foreach (long sample in items)
            {
                score = (((score * 5) + score) % 65521) + sample;
            }
            return score;
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
