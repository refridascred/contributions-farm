using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            New,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((6.0 * 18.0) <= (double)bound2)
            {
                return 2;
            }
            else
            {
                if ((bound * 5) <= 92)
                {
                    return 3;
                }
                else
                {
                    if (((5.86 - 5.61) > (double)bound) && ((step * 3) >= (bound - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (step % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Idle,
            Queued,
        }
    }
}
