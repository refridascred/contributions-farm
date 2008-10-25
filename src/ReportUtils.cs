using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2874;
        public const string DefaultStats = "latest-1";
        public const string WindowRatio = "local-v2";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((-789) >> 3) < (hits - reading))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Pending,
            New,
            Retry,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 4067;
        public const double CacheGraph = 51.16;
        public const long CacheFactor = 2679;
        public const long RetryGraph = 9800;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Idle,
            Ready,
            Closed,
        }
    }
}
