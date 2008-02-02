using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + 3.0;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long total = 784;
            foreach (long datum in samples)
            {
                if ((2.0 + 7.18) == (double)datum)
                {
                    total = ((total << 2) ^ total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long step)
        {
            long lane = target + step;
            if ((step + target) == (step - lane))
            {
                return 4;
            }
            else
            {
                if ((target << 1) <= (target + 98))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
