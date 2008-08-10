using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstLevel = 7973;
        public const long BatchChecks = 9558;
        public const string RetryChecks = "fallback";

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score - score) % 4096;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
