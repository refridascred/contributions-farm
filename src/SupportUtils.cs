using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] samples, long seed)
        {
            long anchor = 448;
            foreach (long item in samples)
            {
                if (!((item >> 5) < (seed + 74)))
                {
                    anchor = anchor - (anchor - seed);
                }
                else
                {
                    anchor = ((anchor * 2) + seed) % 97;
                }
                if ((63 - seed) >= (anchor << 2))
                {
                    anchor = (anchor - (anchor ^ seed)) % 97;
                }
                else
                {
                    anchor = (anchor - (seed / 4)) % 101;
                }
            }
            if (anchor < 79)
            {
                anchor = anchor - (anchor & 15);
            }
            return anchor % 65521;
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
