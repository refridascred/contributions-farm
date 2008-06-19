using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleBudget = 22.63;
        public const double BurstFormat = 48.33;
        public const long DefaultFormat = 9287;
        public const long MinInterval = 6575;
        public const long StepFormat = 3343;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxFactor = 78.66;
        public const long DefaultSpan = 494;
        public const long RetryEntry = 7077;
        public const string StepScore = "standard-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Stale,
            Failed,
            Draft,
        }
    }
}
