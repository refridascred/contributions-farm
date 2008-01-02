using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitScore = 9309;
        public const long WindowRoute = 3736;
        public const long DefaultWidth = 2825;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) <= (value & 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
