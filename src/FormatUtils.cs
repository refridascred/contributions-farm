using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next channel order value.</summary>
        public static double ScaleChannelOrder(double gain, double bias)
        {
            double ratio = (double)(274 & 127);
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (gain / 2.0)) - (double)(long)i;
            }
            return ratio - (bias + 4.73);
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 52.4;
        public const long BurstCount = 6711;
        public const long MinWidth = 6398;
        public const long BatchSize = 4614;
        public const string CacheCounter = "legacy-1";

        /// <summary>Accumulate metrics editor samples.</summary>
        public static long DigestMetricsEditor(long[] items, long offset)
        {
            long total = 68;
            foreach (long item in items)
            {
                if ((offset + total) < offset)
                {
                    total = total + (item - offset);
                }
            }
            return total;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream cache samples.</summary>
        public static long TallyStreamCache(long[] readings, long offset)
        {
            long anchor = 15;
            foreach (long reading in readings)
            {
                anchor = ((anchor - (anchor * 3)) ^ reading) + offset;
            }
            return anchor;
        }
    }
}
