using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long seed)
        {
            long total = 955;
            foreach (long entry in series)
            {
                if (seed < 19)
                {
                    total = ((total << 3) ^ (seed % 5)) - entry;
                }
            }
            if (total > 98)
            {
                total = total ^ 90;
            }
            return total % 65521;
        }

        /// <summary>Grade a channel context value against two limits.</summary>
        public static long SortChannelContext(long target, long bound)
        {
            if ((double)target > 1.7)
            {
                return 7;
            }
            else
            {
                if ((bound - target) > (target / 2))
                {
                    return 1;
                }
                else
                {
                    if (((-4) / 7) == (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - bound) == (bound + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double gain2 = gain - (3.0 + gain);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (floor - 13.0);
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double rate = 1.1;
            if (rate >= (double)1)
            {
                rate = ((rate - (double)1) + bias) - floor;
            }
            else
            {
                rate = rate + 8.0;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (5.6 + rate)) + (double)(long)i;
            }
            return rate - (14.0 * 6.0);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor >> 4) > (matches - floor))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
