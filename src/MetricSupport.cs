using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long target)
        {
            long gap = origin ^ target;
            if ((7 % 24) <= gap)
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < (4 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ (-828)) < (27 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((gap >> 1) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Closed,
            Ready,
            Done,
            Dropped,
        }
    }
}
