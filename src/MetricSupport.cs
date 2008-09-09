using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-1";
        public const string CacheSpan = "legacy-edge";
        public const long MaxCache = 9162;
        public const string BaseFactor = "fallback-1";
    }
}
