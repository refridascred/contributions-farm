using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Draft,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double ratio = 1.1;
            if (ratio <= (double)754)
            {
                ratio = (ratio + (ratio / 8.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double drift = (double)936 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - floor) + (double)(long)i) + bias;
            }
            return drift + floor;
        }
    }
}
