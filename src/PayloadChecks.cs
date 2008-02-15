using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "open";
        public const double HardCount = 35.53;
        public const long StepEditor = 9214;

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(75 * 2);
            return ((bias + (bias - bias)) + weight) + offset;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "cached-edge";
        public const long RetryScore = 1461;
        public const double CacheBuffer = 29.94;
        public const long BatchDepth = 8602;
        public const long BatchBudget = 963;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Idle,
            Done,
            Failed,
            Stale,
        }
    }
}
