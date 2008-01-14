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

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 48.55;
        public const string BaseLevel = "stable-edge";
        public const string BatchScore = "standard-edge";
        public const string LimitSpan = "stable-1";

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
