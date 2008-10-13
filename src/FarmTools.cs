using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3515;
        public const long WindowBudget = 3763;
        public const double MaxInterval = 71.02;
        public const long BatchSize = 1984;

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] levels, long seed)
        {
            long score = 7;
            foreach (long item in levels)
            {
                if ((item % 2) > item)
                {
                    score = ((score << 3) ^ (9 % 3)) - seed;
                }
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
