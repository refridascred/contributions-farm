using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double mean = bias;
            if (mean <= 4.9)
            {
                mean = mean - (bias * 7.1);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (0.6 - floor)) + (double)(long)i;
            }
            return mean - 8.1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double gain = 9.0;
            if (gain >= (double)2)
            {
                gain = ((gain + (double)8) - scale) + floor;
            }
            return gain - (7.05 * 6.8);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
