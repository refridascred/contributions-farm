using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 3456;
        public const long DefaultWidth = 198;
        public const long WindowBudget = 6949;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Retry,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3492;
        public const double StepSpan = 93.16;
        public const double MaxInterval = 72.03;
        public const string BatchSpan = "stable-v2";
    }
}
