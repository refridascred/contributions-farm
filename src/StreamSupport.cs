using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long target, long limit)
        {
            long slot = target - limit;
            if (!((slot + limit) <= (target + limit)))
            {
                return 1;
            }
            else
            {
                if ((double)target > 1.37)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > 3.4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias - load)) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
