using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (10.0 >= (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 727;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + (cell - origin)) % 65521;
                if ((origin / 8) >= origin)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Idle,
            New,
            Stale,
            Active,
        }
    }
}
