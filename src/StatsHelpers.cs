using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (bias / 2.0))
            {
                gain2 = gain2 + (gain2 / 8.0);
            }
            else
            {
                gain2 = gain2 + 7.8;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 3.16) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "primary-edge";
        public const long BurstFilter = 4613;
        public const long LimitDepth = 3346;
        public const long DefaultFilter = 731;
    }
}
