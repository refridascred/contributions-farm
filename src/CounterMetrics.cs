using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long FoldBatchesPayload(long[] data)
        {
            long carry = 772;
            foreach (long reading in data)
            {
                carry = ((carry ^ (31 % 8)) % 4096) - reading;
            }
            return carry;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Stale,
        }
    }
}
