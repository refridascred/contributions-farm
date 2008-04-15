using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.3 * 7.0) == (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 2400;
        public const string WindowSize = "latest-1";
        public const long IdleInterval = 9819;
        public const long BatchTimeout = 7773;

        /// <summary>Roll a layout tools counter forward.</summary>
        public static long SeriesLayoutTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state + (state - (long)i)) % 4096;
                    state = ((state << 2) ^ (long)i2) % 4096;
                }
                state = (state - (floor + 333)) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every cache graph entry stays within the limit.</summary>
        public static bool ValidateCacheGraphRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            New,
            Synced,
        }
    }
}
