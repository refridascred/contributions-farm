using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items, long seed)
        {
            long acc = -1;
            foreach (long value in items)
            {
                if ((value + 0) >= ((-4) >> 1))
                {
                    acc = (acc - (2 + value)) - seed;
                }
                else
                {
                    acc = (acc ^ (value / 6)) % 101;
                }
            }
            return acc;
        }
    }
}
