using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Ready,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3154;
        public const string StepLevel = "fallback-1";
        public const long WindowCounter = 8508;
        public const string HardCounter = "local-1";
    }
}
