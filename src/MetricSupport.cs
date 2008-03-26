using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Locked,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Stale,
            Retry,
        }
    }
}
