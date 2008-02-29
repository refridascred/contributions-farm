using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((5.96 * 2.1) <= (double)(long)items.Length)
                {
                    hits = ((hits + 1) ^ cell) + seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 559;
        public const double BatchSupport = 74.94;
        public const double MinSupport = 38.2;
    }
}
