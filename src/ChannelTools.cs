using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 231;
        public const long IdleCluster = 1529;
        public const string HardCluster = "fallback-1";
        public const string BatchInterval = "legacy-edge";
        public const string CacheCount = "standard-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepRatio = 3386;
        public const double CacheLevel = 39.25;
        public const long LimitWidth = 5779;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Queued,
            Paused,
            Synced,
            Draft,
        }
    }
}
