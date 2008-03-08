using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long TallyCommitsFilterOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((189 - matches) < (floor + floor))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 9367;
        public const long StepRatio = 8682;
        public const double CacheDepth = 96.88;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 244;
        public const double MinCluster = 76.71;
        public const long IdleInterval = 2563;
        public const long RetryCluster = 2583;
        public const long BaseCluster = 2331;
    }
}
