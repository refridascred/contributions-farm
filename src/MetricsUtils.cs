using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 6449;
        public const long BatchInterval = 358;
        public const long MinBudget = 4176;
        public const long BurstSize = 567;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
