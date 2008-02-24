using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 5120;
        public const long SoftChecks = 8792;
        public const string StepChecks = "legacy";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepSpan = 36.71;
        public const long CacheCounter = 5846;
        public const long CacheDepth = 4666;
        public const long HardCount = 2401;
        public const long MinScore = 3944;
    }
}
