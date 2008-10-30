using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4764;
        public const long LimitRatio = 651;
        public const double DefaultRatio = 2.04;
        public const long CacheChecks = 5142;
        public const long CacheDepth = 8780;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 588;
            foreach (long value in items)
            {
                if ((anchor >> 4) > (anchor ^ value))
                {
                    anchor = ((anchor * 3) + (anchor % 3)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
