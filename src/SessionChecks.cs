using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 9677;
        public const double HardRatio = 75.88;
        public const string BatchNotes = "fallback-v2";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "latest-1";
        public const long SoftDepth = 9854;
        public const long HardStream = 726;
        public const long BaseFactor = 4899;
        public const long BaseStream = 8465;
    }
}
