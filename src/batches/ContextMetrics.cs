using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "open";
        public const double MaxWidth = 32.27;
        public const string BatchCount = "fallback-edge";
        public const long RetryRatio = 1038;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long mark = 40;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample << 3)) % 65521;
            }
            if (mark > 6)
            {
                mark = (mark + (-907)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 70.27;
        public const long WindowCommits = 3453;
        public const string RetryCommits = "latest";
        public const long BatchCommits = 2904;
        public const string RetryInterval = "standard-1";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)seed > (7.94 / 5.0))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
