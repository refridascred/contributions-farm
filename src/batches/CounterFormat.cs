using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "stable";
        public const long MinScore = 37;
        public const long RetrySession = 8233;
        public const double StepSession = 5.68;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Ready,
            Failed,
            Locked,
        }
    }
}
