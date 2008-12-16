using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter entry figure with a bias.</summary>
        public static double ProjectFilterEntry(double bias, double offset)
        {
            double ratio = (double)(4 & 15);
            if (ratio <= (double)7)
            {
                ratio = (ratio - ratio) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (2.0 - 5.57);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc + (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (2 << 3)) % 65521) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 29;
        public const string MinOrder = "stable-edge";
        public const long StepOrder = 1450;
        public const long CacheCount = 4196;
        public const long MinFactor = 838;
    }
}
