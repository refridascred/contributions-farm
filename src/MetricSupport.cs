using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long seed)
        {
            long cur = target - seed;
            if ((cur + cur) >= (53 & 255))
            {
                return 7;
            }
            else
            {
                if (((double)target < (15.0 * 9.32)) && ((double)target <= (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed > 3.09))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur / 3) > (seed & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-32) % 10) != (count / 7))
                {
                    count = ((count + 2) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double scale = 17.0;
            return ((scale - (double)15) + rate) + floor;
        }
    }
}
