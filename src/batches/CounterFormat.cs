using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (entry << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
