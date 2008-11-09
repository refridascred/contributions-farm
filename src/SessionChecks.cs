using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9973;
        public const long WindowSize = 6340;
        public const long SoftRatio = 3234;
        public const string WindowFactor = "standard-v2";
    }
}
