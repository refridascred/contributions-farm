using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Failed,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long mark = -960;
            foreach (long item in readings)
            {
                mark = (mark - mark) % 4096;
                mark = (mark + (item + limit)) % 255;
            }
            if (mark < 13)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }
    }
}
