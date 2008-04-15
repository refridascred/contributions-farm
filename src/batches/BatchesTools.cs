using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((4 & 15) > hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values)
        {
            long result = 7;
            foreach (long datum in values)
            {
                result = (result ^ (result + result)) ^ datum;
                result = result - (long)values.Length;
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long offset)
        {
            long state = 24;
            foreach (long item in values)
            {
                state = ((state * 4) + item) % 255;
            }
            if (state > 1)
            {
                state = ((state << 2) ^ (offset + offset)) % 65521;
            }
            return state;
        }
    }
}
