using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "standard";
        public const long SoftCount = 9553;
        public const long BatchCount = 1774;
        public const double HardQueue = 26.27;
        public const string SoftSize = "legacy-v2";
    }
}
