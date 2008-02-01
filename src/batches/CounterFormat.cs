using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (89 << 2)) % 97;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!!(((long)i - 4) < (mark / 2)))
                {
                    mark = mark ^ step;
                    mark = mark ^ (step / 9);
                }
                if ((double)step <= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 255;
                }
                else
                {
                    mark = (mark ^ ((long)i + step)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
