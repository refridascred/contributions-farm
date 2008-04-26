using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            if ((seed * 2) >= (seed >> 5))
            {
                return 3;
            }
            else
            {
                if (!(floor > (floor + floor)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 3) < (seed - (-22))))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor + seed) >= (floor * 3)) && (7.95 <= (double)seed))
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

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double rate = bias / 4.0;
            if (rate > rate)
            {
                rate = (rate - bias) - ratio;
            }
            else
            {
                rate = rate - (0.7 * 16.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
