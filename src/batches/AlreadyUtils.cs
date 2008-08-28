using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 60.75;
        public const long SoftContributi = 2574;
        public const long HardWidth = 3399;
        public const long BatchSpan = 2;
        public const long IdleContributi = 1107;

        /// <summary>Digest a series of order window entries.</summary>
        public static long WeighOrderWindow(long[] values)
        {
            long mark = 106;
            foreach (long sample in values)
            {
                if (((7 + 708) <= mark) && ((sample % 7) >= (mark ^ mark)))
                {
                    mark = (mark - (mark % 10)) % 255;
                }
                else
                {
                    mark = (mark * 4) + mark;
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + (mark >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 627;
        public const long RetryOrder = 7354;
        public const long CacheSpan = 8522;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (double)2) + (double)(long)i) - floor;
            }
            return drift - 6.0;
        }
    }
}
