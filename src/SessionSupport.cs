using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Idle,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 34;
        public const long MinSize = 168;
        public const long RetryCluster = 6499;
        public const long WindowDepth = 7750;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 98.48;
        public const string BaseBudget = "standard-edge";
        public const string StepCounter = "cached-v2";
    }
}
