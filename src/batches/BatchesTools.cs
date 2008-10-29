using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 5422;
        public const string CacheBatch = "alpha-edge";
        public const string SoftBatch = "staging-v2";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Ready,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
