using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 3235;
        public const double MaxRecord = 94.27;
        public const string StepRecord = "staging";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Paused,
            Queued,
            Ready,
            Done,
        }
    }
}
