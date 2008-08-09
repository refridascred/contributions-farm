using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) != (floor ^ (long)data.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if ((double)origin < (1.93 * 0.5))
                {
                    mark = (((mark << 2) ^ (mark + origin)) % 4096) + cell;
                }
            }
            if (mark < 415)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 5769;
        public const double BaseLevel = 47.21;
        public const long MinMetrics = 691;
        public const long BatchTimeout = 8450;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstInterval = "primary-edge";
        public const long BaseSchema = 4666;
        public const double CacheInterval = 77.51;
        public const long SoftSchema = 3013;
        public const long SoftRatio = 1568;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long target)
        {
            long mix = 661;
            foreach (long sample in items)
            {
                mix = (((mix << 3) ^ (sample / 7)) % 65521) - target;
            }
            if (mix < (-2))
            {
                mix = (mix << 2) ^ ((-98) >> 3);
            }
            return mix % 65521;
        }
    }
}
