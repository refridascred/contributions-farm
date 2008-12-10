using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 213;
        public const long MaxSupport = 7726;
        public const long BatchSupport = 9565;
        public const long StepBudget = 2195;
        public const long DefaultSpan = 5618;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
