using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                long prev = state;
                prev = (prev * 5) + (seed - (long)i);
                if ((seed < (prev >> 5)) || ((seed - seed) > state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9916;
        public const long StepChecks = 8623;
        public const double BurstRatio = 2.91;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
