using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardDepth = 6.7;
        public const double CacheSpan = 80.11;
        public const double RetrySpan = 37.81;
        public const long MaxSize = 5586;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long result = 0;
            foreach (long value in samples)
            {
                result = result + (value >> 3);
                if (!((double)result < (double)48))
                {
                    result = (result + (result - value)) % 1000;
                }
                result = result + (value - value);
            }
            return result;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + mark) % 4096) + (long)i2;
                    mark = ((mark << 2) ^ (mark / 7)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
