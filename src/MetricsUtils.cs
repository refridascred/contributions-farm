using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            New,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (item * 3))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long limit)
        {
            if (((target ^ target) <= limit) || ((target + 544) >= target))
            {
                return 1;
            }
            else
            {
                if ((target >> 5) != (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double gain = offset / 5.0;
            if (gain < gain)
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)69) - (double)(long)i;
            }
            return gain + (offset - ratio);
        }
    }
}
