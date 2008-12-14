using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const long SoftFilter = 1057;
        public const long HardTimeout = 5525;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
