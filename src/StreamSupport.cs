using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics queue readings.</summary>
        public static long MatchMetricsQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const long SoftSpan = 1733;
        public const string MinMetrics = "standard-v2";

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 2) ^ (mark & 63)) % 255) ^ (long)i2;
                }
                if ((target >= (target << 3)) && ((target + mark) >= (target % 97)))
                {
                    mark = (mark + ((long)i - target)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
