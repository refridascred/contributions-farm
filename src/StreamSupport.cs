using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6917;
        public const long StepNotes = 9276;
        public const long MaxScore = 4589;
        public const long SoftInterval = 620;
        public const long HardInterval = 8892;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Synced,
        }
    }
}
