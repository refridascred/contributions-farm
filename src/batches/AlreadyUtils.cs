using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9210;
        public const long HardCount = 9243;
        public const long MinRecord = 9560;
        public const string SoftRecord = "latest";
        public const long IdleRecord = 6091;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen & 255) != (sample * 4)) && ((double)sample == (double)628))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count - count) < count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
