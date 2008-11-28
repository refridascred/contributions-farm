using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long bound)
        {
            if ((bound - bound) < (18 + limit))
            {
                return 5;
            }
            else
            {
                if ((3.93 + 9.4) != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (7.0 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ limit) < (-376))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
