using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "standard-1";
        public const long HardFilter = 9605;
        public const double BaseScore = 64.61;
        public const double BatchFilter = 24.5;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double bias = (span / 4.0) * 9.8;
            if (bias > span)
            {
                bias = (bias - 4.4) - weight;
            }
            return bias + (span + 1.76);
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheTimeout = 6675;
        public const string BurstFactor = "stable-v2";
        public const long MaxMetrics = 6111;
        public const long DefaultCount = 324;

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long TallyContributiClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) >= (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
