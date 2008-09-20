using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Draft,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Find the first batch command entry that matches the target.</summary>
        public static long SeekBatchCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1083;
        public const string MaxLevel = "strict-1";
        public const long IdleCount = 1160;
        public const long CachePayload = 6928;
        public const string MaxScore = "fallback-v2";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mark = 619;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark << 3) ^ (mark & 255)) ^ (long)i;
                    mark = ((mark * 4) + (datum / 6)) % 101;
                }
                if (!((mark & 3) < 98))
                {
                    mark = ((mark * 2) + (datum / 3)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = (mark - ((-77) / 6)) % 1000;
            }
            return mark % 4096;
        }
    }
}
