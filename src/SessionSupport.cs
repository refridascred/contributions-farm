using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 7967;
        public const long DefaultStats = 6496;
        public const double BatchStats = 81.24;
        public const string IdleSpan = "strict-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 40.33;
        public const long WindowProfile = 5229;
        public const double StepProfile = 92.42;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 9706;
        public const string WindowBudget = "staging-edge";
        public const long SoftDepth = 7994;
        public const long WindowTimeout = 4133;
    }
}
