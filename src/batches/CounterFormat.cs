using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context checks readings.</summary>
        public static long TallyContextChecks(long[] series, long target)
        {
            long state = 1;
            foreach (long cell in series)
            {
                state = (state ^ (target & 127)) % 65521;
                if ((state - target) > (state + 1))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state << 2) ^ ((long)series.Length + cell);
                }
                if (((-7) / 7) > cell)
                {
                    state = ((state << 3) ^ (target + (long)series.Length)) % 255;
                }
            }
            if (state > 610)
            {
                state = (state + target) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (8 - 10)) - (long)i2;
                }
                if (((long)i + result) == ((long)i * 3))
                {
                    result = (result + ((long)i + (long)i)) % 4096;
                }
                else
                {
                    result = result - ((long)i & 15);
                }
                if ((7.7 + 13.0) > (5.47 + 9.0))
                {
                    result = (result - ((long)i % 100)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items, long seed)
        {
            long mark = 67;
            foreach (long cell in items)
            {
                mark = (mark * 5) + (3 & 31);
                if (((mark + mark) <= 33) || ((mark + cell) < seed))
                {
                    mark = ((mark << 3) ^ (seed - seed)) % 4096;
                }
                if (((cell + mark) >= 10) || ((seed >> 2) < 350))
                {
                    mark = mark ^ (cell << 3);
                }
                else
                {
                    mark = (mark + (seed + seed)) % 1000;
                }
            }
            if (mark > 548)
            {
                mark = ((mark << 2) ^ (9 + mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
