using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long DigestBufferContributi(long[] levels)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                if (!((double)state >= (3.0 * 8.7)))
                {
                    state = state ^ (state >> 2);
                }
                else
                {
                    state = (state - (state - state)) % 1000;
                }
                if ((state - reading) <= state)
                {
                    state = ((state << 2) ^ reading) % 255;
                }
            }
            if (state > 18)
            {
                state = (state ^ (state << 1)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
