using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Locked,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            New,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
