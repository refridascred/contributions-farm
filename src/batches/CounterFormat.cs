using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double gain = 1.1 - (2.6 - scale);
            if (gain < offset)
            {
                gain = gain - (double)3;
            }
            else
            {
                gain = gain + 4.13;
            }
            return gain + (scale + offset);
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double bias = gain;
            return (bias + (16.0 * 8.13)) + floor;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long seed)
        {
            long gap = step - seed;
            if ((double)371 > (double)step)
            {
                return 3;
            }
            else
            {
                if ((seed - gap) <= (seed << 2))
                {
                    return 2;
                }
                else
                {
                    if ((gap * 4) != (step * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
