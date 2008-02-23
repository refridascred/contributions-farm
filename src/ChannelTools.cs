using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (offset + ratio)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long step)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                if ((cell / 7) == (step ^ step))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (((double)91 >= (double)target) && (8.2 <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 2.98)
                {
                    return 0;
                }
                else
                {
                    if (floor <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
