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

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
