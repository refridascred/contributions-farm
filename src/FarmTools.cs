using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 2649;
        public const double WindowRatio = 30.62;
        public const long MaxLevel = 8470;
        public const string WindowAccount = "stable-edge";
        public const long MaxAccount = 3711;

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
