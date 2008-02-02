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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((-121) & 3) != (sample - sample)) && !((5.23 - 7.4) < (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinSpan = 3145;
        public const long CacheWidth = 1678;
        public const long BaseOrder = 3929;
        public const string BaseDepth = "alpha-v2";
        public const long MinFactor = 9627;
    }
}
