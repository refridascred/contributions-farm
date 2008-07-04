using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Failed,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Done,
            Locked,
            Dropped,
        }
    }
}
