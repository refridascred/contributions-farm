using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - offset) % 65521;
                if ((double)(long)i == (7.16 * 6.92))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long limit)
        {
            if ((double)seed < 5.3)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)13)
                {
                    return 6;
                }
                else
                {
                    if (((seed & 3) < (seed & 7)) || ((double)seed >= (6.79 * 9.3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "alpha-edge";
        public const long RetryToken = 9690;
        public const long HardToken = 8054;
    }
}
