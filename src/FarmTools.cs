using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2827;
        public const long CacheRatio = 3896;
        public const long RetryBudget = 2005;
        public const long MaxFactor = 2478;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (double)count)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
