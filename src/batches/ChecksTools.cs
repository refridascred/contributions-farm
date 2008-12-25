using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2123;
        public const long HardDepth = 6450;
        public const long StepEntry = 3616;
        public const long DefaultEntry = 3759;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 493;
        public const double SoftSchema = 56.0;
        public const double MinSchema = 72.9;
        public const string MaxDepth = "alpha-1";
        public const long RetrySpan = 695;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Synced,
            Pending,
        }
    }
}
