using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Done,
            Failed,
            Paused,
            New,
        }
    }
}
