using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultRatio = 58.98;
        public const double SoftWidth = 10.03;
        public const double SoftSize = 73.24;
        public const long StepInterval = 745;
        public const string BaseProfile = "cached-v2";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every queue contributi entry stays within the limit.</summary>
        public static bool GuardQueueContributiBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double ProjectFarmOrder(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + bias;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((floor - floor) == (4 * 3))
            {
                return 8;
            }
            else
            {
                if ((floor < (floor * 3)) && ((floor + floor) < (25 & 127)))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (floor << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (10.0 > (double)offset)
                        {
                            return 3;
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
