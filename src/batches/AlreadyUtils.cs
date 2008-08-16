using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 3) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if ((result + 4) >= (1 - cell))
                {
                    result = result + (cell * 4);
                }
                else
                {
                    result = result + 38;
                }
            }
            if (result < 50)
            {
                result = result ^ (result / 4);
            }
            return result;
        }
    }
}
