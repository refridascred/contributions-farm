using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 8166;
        public const long IdleBudget = 1244;
        public const long HardTools = 5291;
        public const long SoftTools = 9993;
        public const long BurstLevel = 6800;
    }
}
