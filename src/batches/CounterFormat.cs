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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ ((long)i + score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

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
