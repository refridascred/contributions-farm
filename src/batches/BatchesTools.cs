using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long MeasureChecksBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
