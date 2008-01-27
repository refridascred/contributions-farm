using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8800;
        public const string RetryFactor = "legacy-v2";
        public const long CacheWidth = 5741;
        public const long BatchBudget = 7885;
        public const double RetryCount = 76.37;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            New,
            Stale,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 21.4;
        public const long MaxStats = 4437;
        public const double BatchStats = 47.66;
        public const double SoftStats = 3.05;

        /// <summary>Combine batches metrics values into a single score.</summary>
        public static long CombineBatchesMetrics(long[] values, long origin)
        {
            long state = -96;
            foreach (long value in values)
            {
                state = ((((state * 5) + state) % 255) ^ value) - origin;
            }
            if (state < 3)
            {
                state = (state + 79) % 65521;
            }
            return state % 65521;
        }
    }
}
