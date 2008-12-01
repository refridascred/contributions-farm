using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry record reading by value.</summary>
        public static long FindEntryRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 61.04;
        public const long MinNotes = 112;
        public const long MaxBudget = 3321;
        public const long RetryNotes = 3413;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7239;
        public const long RetryAccount = 4720;
        public const long BatchAccount = 2292;
        public const double HardAccount = 26.02;
    }
}
