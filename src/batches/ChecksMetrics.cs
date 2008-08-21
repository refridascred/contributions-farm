using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 9477;
        public const double RetryStats = 37.68;
        public const double BurstLevel = 44.78;
        public const double WindowStats = 55.59;
        public const long CacheSize = 4545;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches << 3) == (matches + 77)) && (matches <= (reading / 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7541;
        public const double SoftSpan = 89.42;
        public const long LimitBatches = 5850;
        public const string IdleBatches = "stable-v2";
        public const string DefaultInterval = "staging-1";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Stale,
            Paused,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Draft,
            Ready,
        }

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long AuditFarmProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((2.46 + 1.0) >= (double)hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
