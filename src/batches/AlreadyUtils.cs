using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if (((double)limit2 == (8.21 * 2.0)) && ((bound % 5) > (limit - 6)))
            {
                return 7;
            }
            else
            {
                if ((bound >= (655 + bound)) || (bound <= (limit2 + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((25 - limit) != (limit & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((62 + limit2) < (72 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if ((4.24 - 2.0) < (double)floor)
                {
                    mix = (mix << 3) ^ (mix + item);
                }
                else
                {
                    mix = ((mix << 2) ^ (floor + 410)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Synced,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Adjust a checks queue reading.</summary>
        public static double SmoothChecksQueue(double gain, double bias)
        {
            double mean = gain;
            if (mean > (double)607)
            {
                mean = (mean + gain) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.3 / 9.0)) + (double)(long)i;
            }
            return mean + (18.0 / 8.0);
        }
    }
}
