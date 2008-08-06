using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(410 < cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7030;
        public const long DefaultDepth = 4969;
        public const long DefaultFormat = 6092;

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long DeriveFarmSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
