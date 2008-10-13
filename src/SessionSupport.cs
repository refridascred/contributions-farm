using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Paused,
            Active,
            Done,
            Queued,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double bias2 = bias - (double)89;
            return (bias2 - (bias2 / 2.0)) + weight;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
