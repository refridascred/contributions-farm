using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3626;
        public const long LimitRecord = 7197;
        public const long SoftScore = 3115;
        public const long BatchRecord = 2145;
        public const long RetryRatio = 6026;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 0;
            foreach (long value in values)
            {
                mark = ((mark + (mark >> 5)) % 65521) - floor;
                mark = mark - (value ^ (-9));
            }
            return mark % 97;
        }
    }
}
