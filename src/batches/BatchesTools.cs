using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseFactor = 5212;
        public const string WindowOrder = "stable-edge";
        public const long MinSpan = 2598;
    }
}
