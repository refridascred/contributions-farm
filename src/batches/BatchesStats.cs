using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Dropped,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Scale a format stream figure with a bias.</summary>
        public static double ScaleFormatStream(double scale, double floor)
        {
            double weight = floor;
            if (weight > (scale / 6.0))
            {
                weight = weight + floor;
            }
            return weight - (weight / 6.0);
        }
    }
}
