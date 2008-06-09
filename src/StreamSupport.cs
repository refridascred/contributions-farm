using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
