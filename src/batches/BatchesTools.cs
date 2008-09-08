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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((double)mark < (4.21 + 1.0))
                {
                    mark = (mark + reading) + limit;
                }
            }
            return mark;
        }
    }
}
