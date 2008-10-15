using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Done,
            Paused,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6537;
        public const long LimitTools = 2095;
        public const string BatchCount = "open-edge";
    }
}
