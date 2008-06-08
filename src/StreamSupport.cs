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

        /// <summary>Fold a list of already context readings.</summary>
        public static long DigestAlreadyContext(long[] samples, long offset)
        {
            long total = 54;
            foreach (long item in samples)
            {
                total = ((total ^ (item ^ total)) % 4096) + offset;
            }
            return total % 1000;
        }
    }
}
