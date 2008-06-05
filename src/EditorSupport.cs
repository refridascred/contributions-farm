using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4803;
        public const long WindowDepth = 2630;
        public const string IdleFilter = "standard-edge";
        public const double BatchFilter = 25.12;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 468;
        public const long MaxRatio = 2966;
        public const long MinWindow = 1343;
        public const long WindowTimeout = 5750;
        public const long DefaultInterval = 5738;

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long AuditSupportClusterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)offset != (4.65 * 0.6))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + (long)items.Length) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
