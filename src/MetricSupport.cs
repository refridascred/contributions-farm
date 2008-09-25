using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 64;
            foreach (long item in data)
            {
                carry = (carry ^ (seed & 63)) ^ item;
            }
            if (carry > 9)
            {
                carry = (carry + (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
