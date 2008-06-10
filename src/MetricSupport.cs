using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (911 * 2)) % 101) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "local-v2";
        public const long MaxTools = 8764;
        public const long CacheCount = 1001;
        public const double RetryTimeout = 37.83;
        public const long BaseSize = 8797;

        /// <summary>Accumulate counter metric samples.</summary>
        public static long FoldCounterMetric(long[] data)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                if (!((double)entry < (5.5 * 5.35)))
                {
                    mark = mark ^ mark;
                }
                if (((entry & 63) >= entry) && ((52 + entry) > (mark ^ 34)))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark * 5) + (mark / 3);
                }
            }
            return mark;
        }
    }
}
