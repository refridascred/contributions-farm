using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 9091;
        public const long LimitDepth = 5564;
        public const long BurstFormat = 2119;
        public const long HardFormat = 7293;

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBudget = "standard";
        public const string BaseBatches = "local-1";
        public const double MaxBatches = 98.14;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 56.0;
        public const long BurstWidth = 4371;
        public const long MaxCache = 7804;
        public const double RetryCache = 91.21;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
