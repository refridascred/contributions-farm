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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 9426;
        public const long BurstLevel = 4831;
        public const double SoftCounter = 73.39;
        public const long BaseInterval = 4313;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4850;
        public const long SoftFarm = 2875;
        public const long IdleFarm = 68;
        public const double StepFactor = 82.1;
    }
}
