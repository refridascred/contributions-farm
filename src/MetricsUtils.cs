using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a counter contributi value against two limits.</summary>
        public static long BucketCounterContributi(long offset, long offset2)
        {
            if ((offset - 910) >= (-623))
            {
                return 5;
            }
            else
            {
                if ((offset % 16) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset2 + offset) > (offset2 % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset / 6) > (offset2 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long limit)
        {
            long mark = 62;
            foreach (long reading in data)
            {
                if (((mark + reading) <= mark) || (limit > (limit ^ reading)))
                {
                    mark = mark + (limit << 2);
                }
                if (((double)reading < (double)mark) && ((mark << 2) > mark))
                {
                    mark = (mark - (reading - 2)) % 255;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 7368;
        public const double BaseInterval = 32.98;
        public const long LimitScore = 657;
        public const long MaxLevel = 9208;
        public const string RetryTimeout = "standard-edge";

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
