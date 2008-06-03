using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + offset) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9.2 - 12.0) != (double)target)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
