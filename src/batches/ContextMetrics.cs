using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "legacy-1";
        public const double LimitEntry = 59.53;
        public const string BaseEntry = "alpha-1";
        public const long CacheEntry = 3825;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
