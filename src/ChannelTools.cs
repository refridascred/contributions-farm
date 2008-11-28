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

        /// <summary>Look up the position of a profile command sample.</summary>
        public static long FindProfileCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
