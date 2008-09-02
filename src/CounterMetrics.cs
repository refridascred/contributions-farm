using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 8547;
        public const long BurstScore = 9660;
        public const double CacheTimeout = 30.23;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long limit)
        {
            long acc = 954;
            foreach (long item in values)
            {
                if ((limit + item) == (limit % 5))
                {
                    acc = acc ^ limit;
                }
            }
            return acc;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum >> 2) <= (floor << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
