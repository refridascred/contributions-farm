using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((17.0 * 14.0) >= (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryCount = 784;
        public const long RetryRatio = 8365;
        public const double MinAlready = 26.14;
        public const string RetryLevel = "latest-v2";
        public const long StepFactor = 119;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1775;
        public const long MinSize = 7433;
        public const long BurstCount = 3894;
        public const long BatchSpan = 8507;
        public const string MinBuffer = "latest-1";
    }
}
