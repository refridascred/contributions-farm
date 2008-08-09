using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 17.34;
        public const long CacheDepth = 1557;
        public const long HardTimeout = 2395;
        public const long BatchSchema = 8247;
        public const string BatchSize = "primary-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long step)
        {
            if (!((4.12 + 13.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if (floor >= (2 ^ 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long limit)
        {
            long mark = 11;
            foreach (long value in series)
            {
                if (((5.0 * 3.96) < (double)value) && ((value + 14) > (938 ^ mark)))
                {
                    mark = (mark ^ (limit << 2)) % 101;
                }
                if ((mark > (mark + mark)) || (mark >= (value & 63)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
