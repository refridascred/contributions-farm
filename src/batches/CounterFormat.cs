using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 942;
        public const long BatchBudget = 811;
        public const long LimitQueue = 3400;
        public const long MinInterval = 9902;
        public const long SoftQueue = 6580;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value + 0) != (36 ^ value)) || !(4.71 < (double)matches))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long DeriveCacheContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 4) + step;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
