using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2366;
        public const long CacheScore = 645;
        public const long LimitCluster = 9811;
        public const string WindowSize = "legacy-edge";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Closed,
            Failed,
        }
    }
}
