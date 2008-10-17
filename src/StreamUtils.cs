using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (((floor2 + floor) < (edge & 7)) || ((floor2 - floor2) <= (edge >> 3)))
            {
                return 4;
            }
            else
            {
                if ((edge + floor) > edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double span)
        {
            double scale2 = (7.04 - scale) + scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 + (6.3 * 12.0)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - 8.3) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Failed,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
