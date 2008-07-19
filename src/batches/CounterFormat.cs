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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
