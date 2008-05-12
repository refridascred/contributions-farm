using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            New,
        }

        /// <summary>Adjust a metrics route reading.</summary>
        public static double BlendMetricsRoute(double weight, double offset)
        {
            double scale = offset;
            return (scale + scale) + weight;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Stale,
            Synced,
        }
    }
}
