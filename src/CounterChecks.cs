using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double drift = 20.0;
            if (drift > (drift + drift))
            {
                drift = (drift + drift) + ratio;
            }
            return drift - (bias / 2.0);
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double scale = gain;
            return (scale + gain) + bias;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long limit)
        {
            if ((bound + bound) < (bound + 6))
            {
                return 5;
            }
            else
            {
                if (((limit - 17) <= (29 & 63)) || (((-75) - limit) == (limit & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + limit) <= 7)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)(-640) < (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long limit, long offset)
        {
            long step = limit - offset;
            if (((offset * 2) == (offset >> 5)) && ((step % 5) >= step))
            {
                return 6;
            }
            else
            {
                if ((5.3 * 3.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((17.0 - 8.6) == (double)offset) && ((offset * 5) <= (limit + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a order stream figure with a bias.</summary>
        public static double SmoothOrderStream(double gain, double span)
        {
            double ratio = span;
            if (ratio <= span)
            {
                ratio = ratio + gain;
            }
            return ratio - (double)46;
        }
    }
}
