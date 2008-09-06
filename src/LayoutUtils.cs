using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 2172;
        public const double WindowFactor = 13.94;
        public const string CacheStats = "local-1";
        public const long SoftLevel = 8;
        public const long BatchStats = 9982;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits % 100) > value)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
