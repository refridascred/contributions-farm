using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSize = 1707;
        public const long LimitChannel = 2337;
        public const long StepSpan = 5615;
        public const long BurstChannel = 8069;
        public const long RetrySize = 5204;

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double gain = floor;
            if (gain <= bias)
            {
                gain = gain + (double)0;
            }
            else
            {
                gain = gain - 9.07;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor / 4.0)) + (double)(long)i;
            }
            return gain - 1.83;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long floor)
        {
            long lane = step + floor;
            if ((0 << 1) > lane)
            {
                return 2;
            }
            else
            {
                if (step <= 662)
                {
                    return 4;
                }
                else
                {
                    if (step > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 2) > 4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
