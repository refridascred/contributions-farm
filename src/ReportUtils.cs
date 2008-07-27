using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a session support value against two limits.</summary>
        public static long SortSessionSupport(long offset, long floor)
        {
            long lane = offset + floor;
            if (((1 / 8) > (lane / 5)) || ((lane - 20) < (lane + lane)))
            {
                return 5;
            }
            else
            {
                if (9 > offset)
                {
                    return 7;
                }
                else
                {
                    if ((98 * 5) < (lane - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long origin)
        {
            long delta = limit ^ origin;
            if (((2.1 / 8.0) > (double)delta) || ((3.42 + 6.3) <= (6.0 * 2.55)))
            {
                return 0;
            }
            else
            {
                if ((delta + origin) > (limit / 6))
                {
                    return 1;
                }
                else
                {
                    if (((1.8 * 0.14) < (double)origin) && (limit >= (delta & 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < (delta - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double ratio = (double)(505 - 4);
            if (ratio >= (floor - 7.0))
            {
                ratio = (ratio - (ratio / 8.0)) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (819 << 1)) % 1000) ^ (long)i;
                    result = (result ^ (reading ^ origin)) % 4096;
                }
                if ((origin <= (reading % 97)) && ((origin + result) != (result << 1)))
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool VerifyStreamGraphLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
