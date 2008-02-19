using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((seed ^ 986) <= seed) && ((4.0 - 6.0) > (double)state))
                {
                    state = state - state;
                }
                state = ((state << 2) ^ (seed & 255)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((18.0 * 18.0) == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2395;
        public const long IdleMetric = 6301;
        public const long BurstFactor = 371;
        public const long DefaultDepth = 6464;
    }
}
