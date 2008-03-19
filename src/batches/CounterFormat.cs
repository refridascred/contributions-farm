using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count contributi buffer pairs that satisfy a relation.</summary>
        public static long MatchContributiBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if (state > (state + (-7)))
                {
                    state = (state - ((long)i - bound)) % 255;
                }
                else
                {
                    state = state - ((long)i + 848);
                }
                if ((bound > (-3)) && ((long)i >= (state - 72)))
                {
                    continue;
                }
                if (!((state << 1) == (bound / 3)))
                {
                    state = state + state;
                    state = ((state << 3) ^ (state / 9)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((9 + tally) != (tally & 31))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
