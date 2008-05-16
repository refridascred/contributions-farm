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

        /// <summary>Classify a filter format pair into a bucket.</summary>
        public static long RankFilterFormat(long limit, long limit2)
        {
            if ((double)limit != (5.4 * 3.9))
            {
                return 0;
            }
            else
            {
                if (1 > limit)
                {
                    return 7;
                }
                else
                {
                    if ((1.14 / 7.0) > (double)limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
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
