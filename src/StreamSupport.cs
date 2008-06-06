using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Dropped,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const long WindowEntry = 2751;
        public const double DefaultEntry = 21.91;
        public const long StepFactor = 7465;
    }
}
