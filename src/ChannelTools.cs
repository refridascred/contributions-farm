using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Ready,
            Active,
        }
    }
}
