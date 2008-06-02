using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultWidth = 5141;
        public const long WindowCommand = 8450;
        public const long DefaultCommand = 4423;
        public const long WindowSize = 6804;
        public const long HardCommand = 1842;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Locked,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2301;
        public const long StepCount = 884;
        public const long HardScore = 8602;
        public const long DefaultInterval = 7128;
        public const long RetryInterval = 9158;
    }
}
