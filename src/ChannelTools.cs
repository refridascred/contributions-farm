using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
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
