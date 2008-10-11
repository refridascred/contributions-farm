using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count <= (count % 2))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((5.35 * 0.62) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((10.0 * 11.0) > (double)target) || ((target ^ step) <= 34))
                {
                    return 5;
                }
                else
                {
                    if ((step % 97) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen <= bound) && (datum > (seen & 7))) && ((1.25 - 6.46) != (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
