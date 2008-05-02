using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long origin)
        {
            long next = target + origin;
            if ((2 < (6 + origin)) && ((origin ^ next) > origin))
            {
                return 2;
            }
            else
            {
                if ((target >> 3) <= (origin ^ 664))
                {
                    return 0;
                }
                else
                {
                    if ((target * 4) >= (target + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - target) > (31 * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Failed,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Dropped,
            Failed,
            Synced,
            Closed,
        }
    }
}
