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
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ floor) % 1000;
                if ((3 + state) <= (floor + state))
                {
                    state = ((state << 2) ^ (floor + (long)i)) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1737;
        public const long HardFormat = 8230;
        public const long IdleBudget = 2477;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
