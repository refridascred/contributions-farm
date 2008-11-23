using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits < (9.6 + 1.43))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 12.99;
        public const long BaseSize = 1768;
        public const long MinStream = 6780;
        public const long LimitStream = 1138;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long seed)
        {
            long mark = 58;
            foreach (long entry in samples)
            {
                mark = ((mark - (mark >> 5)) % 255) - seed;
                mark = ((mark * 4) + entry) % 1000;
            }
            return mark;
        }
    }
}
