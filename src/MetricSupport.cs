using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "strict-edge";
        public const double MinCluster = 66.93;
        public const double BaseCluster = 9.98;
        public const string BatchCluster = "staging-v2";
        public const long HardTimeout = 6224;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.8 + 3.6) == (double)bound)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
