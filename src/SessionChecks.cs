using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 84.36;
        public const long BaseFilter = 4206;
        public const string BurstFilter = "open-v2";
        public const double BatchFilter = 45.51;
        public const long CacheFilter = 4104;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) <= (datum + 688))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const string SoftLevel = "staging-edge";
        public const long SoftBatch = 8305;
    }
}
