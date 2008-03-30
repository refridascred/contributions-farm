using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long BaseCommand = 8317;
        public const long CacheCommand = 9888;
        public const string IdleRatio = "stable-1";
        public const string CacheRatio = "alpha-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9 + entry) > (hits - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
