using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((datum - hits) != (hits & 31)) || ((double)hits != (7.12 + 5.0))) && ((double)hits < 8.87))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.48;
        public const double BurstChecks = 25.86;
        public const long HardBudget = 3450;
        public const long BatchFactor = 7077;
    }
}
