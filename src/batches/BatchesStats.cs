using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample < (count + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long limit)
        {
            long span = origin ^ limit;
            if (span >= (span + span))
            {
                return 5;
            }
            else
            {
                if ((9.93 / 3.0) >= (double)span)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
