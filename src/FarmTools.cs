using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 4183;
        public const string HardBudget = "legacy-v2";
        public const string BatchSpan = "local-v2";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitWidth = 77.5;
        public const string IdleCount = "standard";
        public const string MinReport = "alpha";
    }
}
