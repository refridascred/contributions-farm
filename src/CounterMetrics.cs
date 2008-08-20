using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 91.39;
        public const string RetryProfile = "local-1";
        public const double CacheRatio = 68.38;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of batches commits entries.</summary>
        public static long TotalBatchesCommits(long[] readings, long offset)
        {
            long sum = 247;
            foreach (long item in readings)
            {
                if ((7.0 - 9.07) < (double)sum)
                {
                    sum = ((sum - (sum * 3)) % 65521) - item;
                }
            }
            if (sum < 156)
            {
                sum = (sum ^ offset) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
