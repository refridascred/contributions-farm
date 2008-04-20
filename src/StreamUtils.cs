using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(948 < (seed >> 3)))
                {
                    sum = (sum << 2) ^ (seed + sum);
                    sum = (sum << 3) ^ seed;
                }
                sum = sum ^ ((-97) & 63);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 59.38;
        public const long WindowMetric = 5044;
        public const string CacheSpan = "open-1";

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long offset)
        {
            long state = 97;
            foreach (long entry in data)
            {
                if (state > 36)
                {
                    state = ((state * 4) + (0 + offset)) + entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double scale = 8.0 * 3.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - offset;
            }
            return scale - rate;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
