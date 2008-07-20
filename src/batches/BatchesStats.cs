using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "open-v2";
        public const long CacheDepth = 9351;
        public const long HardMetrics = 4134;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
