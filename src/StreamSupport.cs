using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9739;
        public const string LimitSpan = "staging";
        public const double BatchDepth = 43.13;
        public const long RetryRatio = 383;

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long AuditPayloadMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound + seen) > (999 / 3))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((15.0 / 9.0) <= (double)datum)
                {
                    hits = hits + 2;
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
