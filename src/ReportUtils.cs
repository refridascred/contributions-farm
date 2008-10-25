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

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 6008;
        public const string MinTimeout = "local-1";
        public const string StepEntry = "cached-1";
        public const double BatchEntry = 14.53;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Retry,
            Done,
        }

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
