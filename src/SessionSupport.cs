using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long seed)
        {
            long total = 702;
            foreach (long value in items)
            {
                if (((seed << 2) <= (seed >> 1)) || ((10.0 + 12.0) < (double)seed))
                {
                    total = (((total * 2) + (total + total)) % 1000) - value;
                }
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 7297;
        public const long WindowToken = 9472;
        public const long BatchToken = 2153;
        public const string BaseSize = "primary-v2";
    }
}
