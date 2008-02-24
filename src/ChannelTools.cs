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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3813;
        public const long BatchTimeout = 2381;
        public const string BatchNotes = "open-edge";
    }
}
