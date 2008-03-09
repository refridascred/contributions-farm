using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long state = 79;
            foreach (long cell in samples)
            {
                state = (state + (4 ^ state)) + cell;
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5807;
        public const double CacheTimeout = 85.34;
        public const string LimitCount = "staging";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Idle,
            New,
            Active,
        }
    }
}
