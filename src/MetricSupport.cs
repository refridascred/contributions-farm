using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 2) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "alpha";
        public const long LimitBatches = 7937;
        public const long StepRatio = 1619;
        public const double BaseBatches = 70.5;
        public const long BatchBatches = 6787;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6538;
        public const double SoftPayload = 24.24;
        public const string StepPayload = "legacy-1";
    }
}
