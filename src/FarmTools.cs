using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 2174;
        public const long BaseMetric = 926;
        public const long IdleLevel = 8564;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Failed,
            New,
            Retry,
            Ready,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Dropped,
            Paused,
            Draft,
        }
    }
}
