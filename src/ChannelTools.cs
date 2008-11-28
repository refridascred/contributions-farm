using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TotalQueueFarm(long[] levels, long target)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if ((entry ^ sum) > (8 << 1))
                {
                    sum = ((sum - (entry / 6)) % 101) + target;
                }
            }
            return sum;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long step)
        {
            if ((9.61 + 7.82) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((double)floor > (9.0 + 1.6))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two format metrics measurements.</summary>
        public static double AdjustFormatMetrics(double gain, double floor)
        {
            double scale = gain;
            if (scale <= (double)87)
            {
                scale = scale + (scale - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (4.0 * 0.43)) + (double)(long)i;
            }
            return scale + (1.45 - floor);
        }
    }
}
