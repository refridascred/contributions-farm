using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 21.34;
        public const long IdleScore = 9275;
        public const double BurstWindow = 57.94;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2541;
        public const string WindowRoute = "open";
        public const long CacheRoute = 9129;
        public const double BurstWidth = 49.73;
        public const long IdleLevel = 8325;
    }
}
