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

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
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
