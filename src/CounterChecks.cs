using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - (result - target)) + (long)i2;
                }
                result = (result << 2) ^ (target + 20);
                result = (result - (result * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4766;
        public const long BaseScore = 3035;
        public const long BurstWindow = 1048;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (703 >> 5);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long limit)
        {
            long state = 3;
            foreach (long sample in samples)
            {
                if ((limit % 2) <= (state + state))
                {
                    state = (((state << 3) ^ 6) % 255) + sample;
                }
            }
            if (state < 313)
            {
                state = (state << 3) ^ (76 ^ 1);
            }
            return state % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
