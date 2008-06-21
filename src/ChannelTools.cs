using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
