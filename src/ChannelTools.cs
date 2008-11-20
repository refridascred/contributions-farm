using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
