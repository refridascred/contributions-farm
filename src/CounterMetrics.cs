using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxRatio = 82.68;
        public const long CachePayload = 5209;
        public const double LimitLevel = 36.71;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i >> 2) < (879 / 7))
                {
                    acc = (acc - (74 << 1)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
