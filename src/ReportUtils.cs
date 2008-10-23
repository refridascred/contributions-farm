using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a cache format reading by value.</summary>
        public static long LocateCacheFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double drift = (floor / 9.0) / 3.0;
            if (drift >= weight)
            {
                drift = drift + drift;
            }
            return drift + (double)272;
        }

        /// <summary>Look up the position of a counter layout sample.</summary>
        public static long FindCounterLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = score + (long)i;
                score = ((score << 2) ^ step) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
