using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long LimitTools = 709;
        public const long StepScore = 6380;
        public const double WindowBudget = 69.53;
    }
}
