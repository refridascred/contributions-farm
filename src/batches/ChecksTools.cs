using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 64.2;
        public const string BatchSpan = "legacy";
        public const double MaxPayload = 35.07;
        public const long MaxDepth = 153;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
