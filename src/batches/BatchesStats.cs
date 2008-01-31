using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 5112;
        public const double BaseSpan = 98.58;
        public const long BurstOrder = 3361;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheDepth = 3785;
        public const long WindowQueue = 5079;
        public const string MaxQueue = "primary";
        public const long MinDepth = 5095;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
