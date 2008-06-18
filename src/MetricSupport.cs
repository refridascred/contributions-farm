using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 1145;
        public const long RetryTimeout = 1118;
        public const string IdleFactor = "local-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 271;
        public const long MaxScore = 5398;
        public const double DefaultWidth = 81.22;
        public const long DefaultDepth = 3832;
        public const string BurstFactor = "stable";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Paused,
            Queued,
            Active,
            Failed,
        }
    }
}
