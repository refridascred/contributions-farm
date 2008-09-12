using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 9220;
        public const long BatchCommits = 1975;
        public const string MaxFactor = "latest-1";
        public const double BurstLevel = 59.46;

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + mark) != (mark / 9)) || ((mark + 1) < (limit + (-3))))
                {
                    mark = (mark ^ limit) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark - (long)i) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
