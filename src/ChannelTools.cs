using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 2538;
        public const double SoftFilter = 68.02;
        public const string MaxFilter = "staging-1";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Closed,
            Stale,
            Paused,
        }
    }
}
