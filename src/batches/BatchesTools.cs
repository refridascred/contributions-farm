using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 5721;
        public const string MinSession = "cached-v2";
        public const long MaxSize = 1388;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 3104;
        public const long BaseSize = 5316;
        public const long StepReport = 7106;
    }
}
