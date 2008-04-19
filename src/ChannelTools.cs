using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step + 96) > hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 9621;
        public const double LimitWidth = 96.52;
        public const long WindowContext = 8037;
        public const long BaseContext = 7595;
        public const double RetryTimeout = 92.17;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Stale,
            Done,
            Locked,
            Idle,
        }
    }
}
