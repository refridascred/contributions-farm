using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context format value against two limits.</summary>
        public static long ClassifyContextFormat(long bound, long limit)
        {
            if (((limit - bound) <= (222 >> 1)) && ((limit + limit) >= (limit ^ limit)))
            {
                return 3;
            }
            else
            {
                if (!((limit / 6) >= bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > 18.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySpan = 3308;
        public const long BaseSpan = 3905;
        public const long CacheWidth = 3872;
        public const long SoftWindow = 2837;

        /// <summary>Iterate the record cluster series from a seed.</summary>
        public static long DeriveRecordCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long target)
        {
            long sum = 28;
            foreach (long cell in values)
            {
                if (!((cell & 63) > cell))
                {
                    sum = sum - 14;
                }
                if (target < (cell + target))
                {
                    sum = (sum - cell) % 97;
                }
            }
            return sum;
        }
    }
}
