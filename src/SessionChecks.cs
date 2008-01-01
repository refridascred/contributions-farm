using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Failed,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 8838;
        public const double RetryBatch = 9.86;
        public const long StepSize = 7011;
        public const double BaseBatch = 91.91;
        public const double BatchBudget = 24.41;
    }
}
