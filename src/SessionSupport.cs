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

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 65.6;
        public const double BatchEditor = 49.54;
        public const long MinEditor = 3068;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 98.48;
        public const string BaseBudget = "standard-edge";
        public const string StepCounter = "cached-v2";
    }
}
