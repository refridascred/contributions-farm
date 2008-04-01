using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Locked,
            Active,
            Ready,
        }
    }
}
