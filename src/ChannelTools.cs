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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count + count) >= (count + item)) || (((long)items.Length >> 4) >= (count + 10)))
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
