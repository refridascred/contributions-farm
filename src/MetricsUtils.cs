using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 2991;
        public const double LimitCount = 1.78;
        public const double BatchBudget = 0.17;
        public const string BatchSession = "fallback";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 695;
            foreach (long reading in data)
            {
                if ((double)reading < 5.78)
                {
                    result = result ^ (reading % 10);
                }
                result = ((result * 4) + reading) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 7912;
        public const string BurstLevel = "staging-1";
        public const long StepLevel = 5020;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
