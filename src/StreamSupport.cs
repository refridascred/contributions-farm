using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2605;
        public const long BaseFactor = 1846;
        public const string IdleFormat = "local-v2";
        public const string LimitFormat = "staging-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Done,
            Dropped,
        }
    }
}
