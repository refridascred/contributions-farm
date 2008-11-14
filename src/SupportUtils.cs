using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of counter format entries.</summary>
        public static long TotalCounterFormat(long[] items, long limit)
        {
            long total = 69;
            foreach (long value in items)
            {
                if ((double)limit < (double)value)
                {
                    total = ((total * 5) + (limit + 53)) % 4096;
                }
                total = total ^ (limit & 31);
                if ((double)value < (double)limit)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double ratio = (double)124 - (double)8;
            if (ratio >= (floor - floor))
            {
                ratio = ratio + gain;
            }
            return ratio + floor;
        }
    }
}
