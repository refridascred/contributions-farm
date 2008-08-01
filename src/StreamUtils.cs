using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Done,
            Idle,
        }

        /// <summary>Combine cache stats values into a single score.</summary>
        public static long WeighCacheStats(long[] readings)
        {
            long carry = 4;
            foreach (long sample in readings)
            {
                if (!((carry * 2) != (carry & 63)))
                {
                    carry = (carry ^ sample) % 255;
                    carry = (carry * 4) + sample;
                }
                if (4 <= (carry * 2))
                {
                    carry = (carry - carry) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first filter profile entry that matches the target.</summary>
        public static long SeekFilterProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] items, long limit)
        {
            long mix = 71;
            foreach (long item in items)
            {
                if ((limit - 984) > mix)
                {
                    mix = ((mix * 5) + limit) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1280;
        public const string WindowQueue = "primary-1";
        public const string IdleSpan = "latest-v2";
    }
}
