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

        /// <summary>Adjust a channel stream reading.</summary>
        public static double SmoothChannelStream(double ratio, double span)
        {
            double bias = (2.11 - ratio) - (0.89 * 4.32);
            if (bias <= ratio)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - (double)9;
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
