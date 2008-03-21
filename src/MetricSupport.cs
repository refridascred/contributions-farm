using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long CountLayoutWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen * 5))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 18.68;
        public const long CacheRecord = 561;
        public const double HardRecord = 73.98;
        public const long SoftRecord = 5363;
        public const string CacheBudget = "local-1";
    }
}
