using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long offset2)
        {
            if ((2.0 > (double)offset) || ((offset2 - offset) != (offset2 - offset2)))
            {
                return 7;
            }
            else
            {
                if (((238 + offset) == (41 << 3)) || ((offset / 6) < offset2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double scale = ratio + (floor - ratio);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)98) + (double)(long)i;
            }
            return scale + (floor + floor);
        }
    }
}
