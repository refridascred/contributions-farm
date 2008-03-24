using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSize = 85.09;
        public const long MinCluster = 5031;
        public const double BaseCluster = 14.09;
        public const long WindowSize = 6668;

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
