using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((double)origin > (3.2 + 6.22)) && ((0.8 * 8.3) <= (5.09 * 3.2)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "latest-1";
        public const long StepSize = 1723;
        public const long IdleRoute = 6732;
        public const double BaseRoute = 90.11;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
