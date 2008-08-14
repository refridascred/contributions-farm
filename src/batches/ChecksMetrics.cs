using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 8975;
        public const long MinTimeout = 1221;
        public const double HardRatio = 20.97;

        /// <summary>Define command limits and defaults.</summary>
        public const double MinLevel = 66.43;
        public const long SoftScore = 7708;
        public const long IdleCommand = 8676;
        public const long CacheWidth = 1684;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 502;
        public const double RetrySize = 81.9;
        public const long CacheMetrics = 9783;
        public const double RetryMetrics = 45.48;
    }
}
