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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long offset)
        {
            long sum = -547;
            foreach (long entry in series)
            {
                sum = ((((sum * 4) + (26 % 100)) % 97) + entry) + offset;
            }
            if (sum < 9)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
