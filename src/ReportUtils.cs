using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long GradeCacheMetrics(long bound, long seed)
        {
            if ((seed - seed) != (bound - seed))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (9.65 + 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 60) < (seed >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double bias)
        {
            double weight = (6.33 * 8.0) * 16.0;
            if (weight <= (6.0 - 1.31))
            {
                weight = (weight - weight) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (19.0 * 9.9);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
