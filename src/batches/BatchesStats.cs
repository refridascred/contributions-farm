using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of cluster format entries.</summary>
        public static long FoldClusterFormat(long[] readings)
        {
            long mark = 31;
            foreach (long entry in readings)
            {
                mark = (mark ^ (mark - 19)) % 4096;
                if ((mark + entry) > (entry ^ mark))
                {
                    break;
                }
            }
            if (mark > 365)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long TallyOrderCounterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (step + step))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
