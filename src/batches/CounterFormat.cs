using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ anchor) % 97;
                if ((floor + (long)i) != ((long)i / 7))
                {
                    anchor = anchor - ((long)i % 5);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
