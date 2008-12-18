using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6336;
        public const long CacheLevel = 211;
        public const long SoftSession = 1060;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long floor)
        {
            if (((double)floor >= (double)0) && ((floor >> 3) >= (floor - 86)))
            {
                return 3;
            }
            else
            {
                if (((407 + floor) >= seed) && ((965 ^ (-1)) >= (seed + floor)))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= (5.4 / 3.0)) && ((0.4 * 14.0) <= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
