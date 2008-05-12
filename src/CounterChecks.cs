using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySpan = 2427;
        public const long CacheMetrics = 6635;
        public const long IdleMetrics = 1942;
        public const double BurstMetrics = 33.54;
        public const string LimitWidth = "fallback-v2";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5042;
        public const double MaxSpan = 24.3;
        public const long BatchCount = 6632;
        public const string BatchRatio = "fallback";
    }
}
