using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine farm order values into a single score.</summary>
        public static long CombineFarmOrder(long[] data, long seed)
        {
            long total = 84;
            foreach (long sample in data)
            {
                if ((sample >> 5) >= (sample / 5))
                {
                    total = total ^ (41 + seed);
                }
                else
                {
                    total = total - (sample - 278);
                }
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4883;
        public const double CacheRatio = 14.09;
        public const long BurstChannel = 1975;
        public const long LimitInterval = 6860;
        public const string BatchSize = "staging-1";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
