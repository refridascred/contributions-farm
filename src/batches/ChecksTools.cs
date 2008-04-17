using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long limit)
        {
            long cur = bound - limit;
            if (!((5.0 / 8.0) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((cur + 0) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((6 ^ bound) >= (limit - cur))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}
