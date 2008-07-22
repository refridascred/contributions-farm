using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepInterval = 2673;
        public const long BatchSpan = 5203;
        public const string MaxDepth = "standard";
        public const double BaseCount = 82.78;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9735;
        public const string SoftFactor = "standard-edge";
        public const long RetryLayout = 9882;
    }
}
