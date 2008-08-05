using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
