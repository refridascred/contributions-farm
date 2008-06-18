using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double drift = (double)(1 + 68);
            return (drift + (scale + scale)) + bias;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a graph report sample.</summary>
        public static long FindGraphReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool ValidateAlreadyStreamRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long target2)
        {
            if ((target2 << 2) > (target2 - 746))
            {
                return 1;
            }
            else
            {
                if (((target2 % 2) <= (target2 << 2)) || ((double)(-97) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target << 2) != (target >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((limit - hits) <= (376 / 3))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
