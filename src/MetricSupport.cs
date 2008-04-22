using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ hits) < hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseScore = 91.64;
        public const double DefaultChecks = 28.35;
        public const double BaseSpan = 18.49;
        public const double BurstChecks = 43.76;
        public const long BatchChecks = 5865;
    }
}
