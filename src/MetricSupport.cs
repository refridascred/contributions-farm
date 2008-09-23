using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long bound, long limit)
        {
            long delta = bound ^ limit;
            if (((delta / 3) >= limit) || ((double)delta == (5.0 * 7.0)))
            {
                return 7;
            }
            else
            {
                if ((delta + limit) >= bound)
                {
                    return 3;
                }
                else
                {
                    if (bound <= 30)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Paused,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}
