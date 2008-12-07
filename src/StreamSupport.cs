using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 4353;
        public const long IdleLevel = 2624;
        public const long RetryDepth = 1029;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Ready,
            Dropped,
            Retry,
        }
    }
}
