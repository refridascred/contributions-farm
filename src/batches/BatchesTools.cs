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

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long TallyStreamCache(long[] levels)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((result % 8) != (2 + 23))
                {
                    result = (result + (cell - (long)levels.Length)) % 1000;
                    result = result - (result + result);
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    long span = (result * 4) + (cell / 8);
                    result = result + (span + (long)i);
                }
                result = (result + 55) % 4096;
            }
            return result % 97;
        }
    }
}
