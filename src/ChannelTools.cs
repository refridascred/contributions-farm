using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((sum - sum) == (long)i)
                {
                    sum = sum + (sum << 1);
                    sum = (sum - floor) % 97;
                }
                long hits = (84 ^ (long)i) % 7;
                sum = (sum - hits) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardScore = 65.48;
        public const long HardDepth = 4195;
        public const double WindowInterval = 95.49;
        public const long BatchScore = 8848;
    }
}
