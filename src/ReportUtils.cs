using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long step)
        {
            long slot = limit + step;
            if ((((-415) ^ slot) > (limit + 4)) && (552 >= (step + slot)))
            {
                return 5;
            }
            else
            {
                if ((double)step > (3.97 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if (17.0 > (double)step)
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

        /// <summary>Adjust a order schema reading.</summary>
        public static double ProjectOrderSchema(double weight, double offset)
        {
            double gain = 9.72;
            if (gain >= 17.0)
            {
                gain = ((gain + (double)(-401)) - weight) + offset;
            }
            else
            {
                gain = gain + 7.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (3.48 / 3.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a stats profile counter forward.</summary>
        public static long RollStatsProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long offset, long step)
        {
            if (step <= (67 + 389))
            {
                return 3;
            }
            else
            {
                if (((offset / 4) != (step + step)) && ((4.0 * 9.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
