using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7173;
        public const string MaxStats = "latest";
        public const long RetrySpan = 8233;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7410;
        public const long LimitChannel = 4803;
        public const long LimitSize = 9052;

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open";
        public const string CacheWidth = "alpha-1";
        public const double SoftWidth = 69.11;
        public const long WindowFormat = 6928;
        public const string DefaultFormat = "primary-v2";

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long TallyMetricsSupportHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits < (hits % 2))
                {
                    hits = ((hits + 1) + reading) - origin;
                }
            }
            return hits;
        }
    }
}
