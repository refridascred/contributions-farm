using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxSpan = 70.45;
        public const long HardLevel = 162;
        public const long WindowCommand = 4006;
        public const long HardCommand = 9786;
        public const string BaseCommand = "alpha-1";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 6297;
        public const double BatchChecks = 0.5;
        public const long BurstChecks = 5869;
    }
}
