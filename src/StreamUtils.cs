using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4204;
        public const string HardScore = "strict-edge";
        public const long CacheScore = 8173;
        public const string CacheMetrics = "fallback-v2";
        public const long RetryMetrics = 8840;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long acc = 382;
            foreach (long value in values)
            {
                acc = (acc + (value >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 76.3;
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 4483;
        public const long CacheAlready = 4565;
        public const string DefaultAlready = "latest-v2";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length <= (count + sample)) || ((sample <= count) && ((double)seed <= 2.74)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
