using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Locked,
            Synced,
        }
    }
}
