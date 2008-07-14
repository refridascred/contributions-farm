using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long TallyBatchesCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)2 <= (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            if ((offset * 5) < (5 % 64))
            {
                return 1;
            }
            else
            {
                if (!((429 * 2) < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
