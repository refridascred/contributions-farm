using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "latest";
        public const long CacheProfile = 6393;
        public const string BaseLevel = "latest";
        public const string RetryProfile = "cached-edge";
        public const string BatchSize = "stable-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowScore = "stable-edge";
        public const long DefaultMetric = 6414;
        public const double StepRatio = 11.58;
        public const long BatchWidth = 3165;
    }
}
