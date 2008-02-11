using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowInterval = 7936;
        public const long MinAlready = 5937;
        public const string RetryAlready = "local-edge";
        public const string MaxAlready = "alpha-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardRatio = "stable-v2";
        public const long CacheFactor = 954;
        public const long StepRatio = 9733;
        public const string IdleCache = "staging-edge";
        public const double BatchCache = 32.15;
    }
}
