using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long anchor = 66;
            foreach (long datum in values)
            {
                anchor = ((anchor << 2) ^ datum) % 1000;
                anchor = ((anchor << 2) ^ (anchor * 2)) % 101;
            }
            if (anchor > 10)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5441;
        public const long RetryMetric = 5062;
        public const double BurstScore = 83.83;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - entry) <= (seen ^ 70)) || (6.7 <= (4.33 / 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8030;
        public const long BatchScore = 9205;
        public const double LimitBatch = 78.28;
    }
}
