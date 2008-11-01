using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cache context entries.</summary>
        public static long WeighCacheContext(long[] levels, long limit)
        {
            long acc = -350;
            foreach (long datum in levels)
            {
                if (((19 & 3) >= limit) || ((datum + (-869)) <= ((long)levels.Length + 8)))
                {
                    acc = (acc << 2) ^ (datum << 2);
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "stable-edge";
        public const string MinInterval = "staging-1";
        public const double BatchLevel = 96.2;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Idle,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample ^ hits) > (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
