using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9707;
        public const long MinScore = 2185;
        public const long BaseFilter = 7144;
        public const string RetryFilter = "legacy-1";

        /// <summary>Iterate the buffer report series from a seed.</summary>
        public static long RollBufferReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                if (origin > (574 ^ (long)i))
                {
                    acc = (acc + (acc - origin)) % 1000;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (long)i) % 255) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long LookupRouteClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
