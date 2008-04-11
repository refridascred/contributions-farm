using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 26.73;
        public const string IdleRecord = "latest-v2";
        public const double HardRecord = 5.74;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7707;
        public const long HardLevel = 6885;
        public const long BaseTimeout = 1378;
        public const long RetryFarm = 4601;
        public const double RetrySize = 86.55;
    }
}
