using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double weight = (double)((-752) / 3);
            if (weight <= scale)
            {
                weight = (weight + (weight / 9.0)) + span;
            }
            return weight + weight;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Active,
            Done,
            New,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
