using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6981;
        public const long MinSpan = 5991;
        public const double WindowCount = 0.22;
        public const long MaxScore = 8508;

        /// <summary>Digest a series of already report entries.</summary>
        public static long TotalAlreadyReport(long[] samples)
        {
            long mark = -9;
            foreach (long cell in samples)
            {
                mark = mark ^ (mark ^ mark);
                mark = (mark - (cell % 100)) % 4096;
            }
            if (mark > 4)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
