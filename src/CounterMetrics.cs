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

        /// <summary>Digest a series of stream command entries.</summary>
        public static long ScoreStreamCommand(long[] levels, long origin)
        {
            long mark = 98;
            foreach (long item in levels)
            {
                mark = (mark + (item & 31)) % 1000;
                mark = (mark + (mark - origin)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
