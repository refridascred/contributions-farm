using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseScore = 8040;
        public const string StepCount = "legacy-v2";
        public const long RetryCluster = 9158;
        public const double StepCluster = 21.65;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchLevel = 19.44;
        public const string DefaultSchema = "legacy-v2";
        public const long StepSchema = 60;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Retry,
            Active,
            Paused,
        }
    }
}
