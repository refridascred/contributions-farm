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

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 90.92;
        public const long HardOrder = 3597;
        public const long MaxCount = 9813;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 3661;
        public const long CacheWidth = 9820;
        public const string IdleFilter = "strict-edge";

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
