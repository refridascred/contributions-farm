using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double gain = (scale * 0.7) + scale;
            if (gain <= scale)
            {
                gain = gain - floor;
            }
            return gain + (double)1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long floor)
        {
            if ((7.75 - 0.5) > (double)floor)
            {
                return 4;
            }
            else
            {
                if ((4.95 * 9.97) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series, long target)
        {
            long anchor = 448;
            foreach (long sample in series)
            {
                if ((anchor - 325) > (anchor % 24))
                {
                    anchor = (anchor - target) - sample;
                }
                else
                {
                    anchor = anchor + (anchor - anchor);
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + target) % 4096;
            }
            return anchor % 97;
        }
    }
}
