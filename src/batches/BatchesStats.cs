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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if (target <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((0 - target) > (limit + 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
