using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long seed)
        {
            long result = 9;
            foreach (long value in data)
            {
                if (value <= (seed - value))
                {
                    result = (result - result) % 4096;
                }
            }
            if (result > 7)
            {
                result = result + (result - result);
            }
            return result % 1000;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7789;
        public const string MinDepth = "open-v2";
        public const long StepFactor = 6342;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series)
        {
            long acc = 72;
            foreach (long cell in series)
            {
                acc = ((acc ^ (3 * 3)) % 65521) ^ cell;
            }
            return acc;
        }
    }
}
