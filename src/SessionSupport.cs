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

        /// <summary>Define context limits and defaults.</summary>
        public const string MinBudget = "strict-edge";
        public const double BaseLevel = 67.8;
        public const long RetrySize = 404;
        public const double BurstLevel = 21.76;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 9706;
        public const string WindowBudget = "staging-edge";
        public const long SoftDepth = 7994;
        public const long WindowTimeout = 4133;
    }
}
