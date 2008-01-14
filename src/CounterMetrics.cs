using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the context commits entries that pass the check.</summary>
        public static long AuditContextCommitsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 5) >= (7 + limit))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8030;
        public const string BatchGraph = "staging-v2";
        public const long DefaultGraph = 9050;
    }
}
