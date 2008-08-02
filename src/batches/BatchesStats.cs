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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
