using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepInterval = 6163;
        public const double MinBudget = 85.01;
        public const long SoftSpan = 5616;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Active,
            Paused,
            Closed,
        }
    }
}
