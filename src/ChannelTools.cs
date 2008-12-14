using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 8299;
        public const long SoftQueue = 7190;
        public const long BatchQueue = 1593;
        public const long BaseQueue = 9800;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Closed,
            Queued,
            Done,
            Active,
        }
    }
}
