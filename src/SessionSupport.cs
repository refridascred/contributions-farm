using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepBudget = 3657;
        public const long BaseContributi = 4113;
        public const double MinScore = 11.99;
        public const string SoftTimeout = "primary-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
