using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank channel tools input into a small class.</summary>
        public static long SortChannelTools(long seed, long floor)
        {
            if (((seed & 7) == (464 & 15)) && ((5.1 + 4.82) > (double)floor))
            {
                return 2;
            }
            else
            {
                if (((seed % 64) <= seed) && ((floor / 2) <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor >= 10) || ((seed * 3) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            long offset = target ^ target2;
            if ((double)target2 <= (2.09 + 8.6))
            {
                return 7;
            }
            else
            {
                if ((double)target2 == (5.3 * 2.12))
                {
                    return 3;
                }
                else
                {
                    if ((offset + target2) <= (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ (seed + (long)i)) % 4096;
                score = (score + ((long)i << 1)) % 101;
                score = (score + (seed ^ score)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
