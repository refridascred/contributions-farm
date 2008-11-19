using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits cache entries.</summary>
        public static long FoldCommitsCache(long[] items, long floor)
        {
            long mix = 486;
            foreach (long value in items)
            {
                if ((908 << 3) < floor)
                {
                    mix = mix + (value / 6);
                }
                mix = (mix + (floor ^ value)) % 255;
                mix = (mix - value) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long total = -922;
            foreach (long sample in values)
            {
                total = (total - limit) + sample;
            }
            if (total > 6)
            {
                total = (total * 4) + (17 ^ total);
            }
            return total;
        }
    }
}
