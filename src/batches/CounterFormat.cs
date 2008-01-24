using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats notes entry that matches the target.</summary>
        public static long LookupStatsNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "latest-v2";
        public const double BatchBudget = 6.03;
        public const string LimitInterval = "latest";

        /// <summary>Roll a commits editor counter forward.</summary>
        public static long IterateCommitsEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ ((-9) % 24)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
