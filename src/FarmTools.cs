using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 8242;
        public const double BurstBatches = 53.93;
        public const long HardFactor = 8279;

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long MeasureEntryChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((4.5 - 5.2) < (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
