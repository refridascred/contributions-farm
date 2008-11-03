using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long sum = 191;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry ^ entry)) - limit;
            }
            return sum % 65521;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2760;
        public const double SoftBatches = 10.29;
        public const long WindowBatches = 617;
        public const double CacheBatches = 25.05;
        public const long BatchBatches = 6356;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 946;
        public const string MinBuffer = "stable";
        public const long BaseBuffer = 569;
    }
}
