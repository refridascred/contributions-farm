using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Synced,
            Done,
            Active,
            Retry,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - target) > limit)
            {
                return 0;
            }
            else
            {
                if (!((limit * 2) < ((-50) - 67)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
