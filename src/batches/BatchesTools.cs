using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinFactor = "staging-1";
        public const double BatchWidth = 72.54;
        public const double BatchBudget = 35.86;
        public const double LimitWidth = 34.22;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4850;
        public const long SoftFarm = 2875;
        public const long IdleFarm = 68;
        public const double StepFactor = 82.1;
    }
}
