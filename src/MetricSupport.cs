using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if (!((step / 6) < step))
            {
                return 7;
            }
            else
            {
                if ((target * 3) > (target ^ step))
                {
                    return 1;
                }
                else
                {
                    return 2;
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
