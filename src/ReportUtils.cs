using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            if ((96 - floor) < (bound % 97))
            {
                return 3;
            }
            else
            {
                if ((7.1 * 0.28) < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor - bound) != (bound % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
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
