using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a command graph sample.</summary>
        public static long LookupCommandGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
