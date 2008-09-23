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

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSpan = 9528;
        public const long IdleWidth = 1183;
        public const double HardWindow = 2.47;
        public const long IdleWindow = 4419;

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
