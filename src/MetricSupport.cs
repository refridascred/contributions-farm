using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 4388;
        public const long DefaultDepth = 4700;
        public const double WindowChecks = 1.65;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 3.68;
        public const long BatchBudget = 1408;
        public const long SoftCount = 3393;
        public const string HardPayload = "standard-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Failed,
            Ready,
        }
    }
}
