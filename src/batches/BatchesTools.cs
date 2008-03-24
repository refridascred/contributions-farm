using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph filter values into a single score.</summary>
        public static long CombineGraphFilter(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (sum + (datum / 2)) + seed;
            }
            if (sum > 6)
            {
                sum = (sum + (sum << 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((offset & 63) > tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches filter entries.</summary>
        public static long WeighBatchesFilter(long[] series)
        {
            long result = -5;
            foreach (long cell in series)
            {
                if (!((double)cell < 4.3))
                {
                    result = (result - result) % 65521;
                }
                if ((double)result >= (7.24 * 13.0))
                {
                    result = (result ^ (cell - 1)) % 101;
                }
                else
                {
                    result = result + result;
                }
                result = result - (cell & 31);
            }
            return result;
        }
    }
}
