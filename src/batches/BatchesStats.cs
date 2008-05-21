using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series, long limit)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((((total << 2) ^ total) % 1000) - cell) - limit;
            }
            if (total > 722)
            {
                total = total ^ (total & 7);
            }
            return total % 65521;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mark = 366;
            foreach (long entry in readings)
            {
                mark = ((mark * 2) + (entry >> 4)) % 1000;
            }
            return mark;
        }
    }
}
