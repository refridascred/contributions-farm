using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "latest-v2";
        public const long WindowContext = 2221;
        public const double MaxScore = 88.12;
        public const string MaxContext = "legacy-v2";
        public const long MinInterval = 8878;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((seed + value) <= (hits ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
