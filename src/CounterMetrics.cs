using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - 10) < (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryFactor = 1762;
        public const string BaseGraph = "primary-edge";
        public const string IdleSize = "stable-v2";
        public const long StepGraph = 2280;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
