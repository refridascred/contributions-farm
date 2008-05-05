using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 1677;
        public const long CacheTimeout = 2181;
        public const long RetryPayload = 7043;
        public const double MinPayload = 73.35;
        public const long DefaultSpan = 5122;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first context stats entry that matches the target.</summary>
        public static long FindContextStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
