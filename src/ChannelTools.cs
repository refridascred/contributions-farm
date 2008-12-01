using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Closed,
            Pending,
            Active,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 7271;
        public const long MinDepth = 8916;
        public const long WindowSize = 2557;
        public const long IdleToken = 2482;
        public const double BaseFactor = 35.29;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
