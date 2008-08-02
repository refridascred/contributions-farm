using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long offset2)
        {
            if ((18.0 - 7.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) == (offset % 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long MeasureRouteQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((hits - reading) == (reading % 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 79;
            foreach (long reading in readings)
            {
                total = total + total;
                total = (total + (reading - 68)) % 1000;
                if ((17.0 - 5.01) != (double)total)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 65521;
        }
    }
}
