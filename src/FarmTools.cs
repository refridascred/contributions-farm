using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Locate a queue command reading by value.</summary>
        public static long SeekQueueCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((5.0 * 15.0) == (double)target) && (((target + target) > target) || (seen < (target >> 4))))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
