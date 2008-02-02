using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((state & 7) < ((long)i % 5)) && ((long)i == (state / 9)))
                {
                    state = state - (state >> 3);
                    state = ((state * 2) + (56 - state)) % 1000;
                }
                state = ((state << 2) ^ floor) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches + 42) <= (matches + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
