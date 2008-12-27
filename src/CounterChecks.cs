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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((item + item) == (matches - matches)) || ((item % 3) <= (matches - item))) || !((23 / 2) > item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double mean = (double)97 - (double)6;
            if (mean < rate)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 11.0) + (double)(long)i;
            }
            return mean - (span - rate);
        }
    }
}
