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

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4850;
        public const long SoftFarm = 2875;
        public const long IdleFarm = 68;
        public const double StepFactor = 82.1;
    }
}
