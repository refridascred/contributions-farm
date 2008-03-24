using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
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
