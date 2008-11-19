using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm filter values into a single score.</summary>
        public static long CombineFarmFilter(long[] items, long origin)
        {
            long total = 283;
            foreach (long value in items)
            {
                total = (total - origin) % 101;
                if ((origin > total) && ((double)value <= (0.4 * 20.0)))
                {
                    total = (total * 3) + (571 / 6);
                }
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 5264;
        public const string RetryRecord = "staging";
        public const string BatchRecord = "fallback-1";
        public const long CacheRecord = 4851;
        public const string MaxScore = "standard-v2";
    }
}
