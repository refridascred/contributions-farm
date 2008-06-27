using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "alpha-v2";
        public const long HardTools = 273;
        public const long HardBudget = 6350;
        public const long BurstTools = 2597;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items, long target)
        {
            long state = 26;
            foreach (long item in items)
            {
                if ((8.6 + 16.0) > (double)item)
                {
                    state = (((state << 2) ^ (item << 3)) % 255) - target;
                }
                else
                {
                    state = ((state * 3) + (34 << 1)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
