using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = (state + offset) % 65521;
                if (((offset ^ reading) < (reading + offset)) && (reading < (11 % 10)))
                {
                    state = (state - (reading + reading)) % 97;
                }
                else
                {
                    state = ((state * 4) + reading) % 65521;
                }
            }
            if (state < 639)
            {
                state = (state ^ (7 + 561)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count <= (5.1 * 20.0))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (seed - acc)) % 255) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
