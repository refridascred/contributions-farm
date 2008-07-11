using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
