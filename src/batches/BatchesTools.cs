using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6972;
        public const long RetryRatio = 6102;
        public const long DefaultEditor = 8140;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes entry series from a seed.</summary>
        public static long StepNotesEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((state / 9) >= (bound ^ (long)i))
                {
                    state = state + (bound / 8);
                }
                else
                {
                    state = ((state << 3) ^ state) % 97;
                    state = state - (bound >> 4);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state * 4) + (state >> 3)) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
