using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + mark) != (mark / 9)) || ((mark + 1) < (limit + (-3))))
                {
                    mark = (mark ^ limit) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark - (long)i) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 5664;
        public const long CacheMetrics = 2136;
        public const double MaxDepth = 50.51;
    }
}
