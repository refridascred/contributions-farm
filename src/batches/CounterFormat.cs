using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 3.5;
        public const long BurstTimeout = 2643;
        public const long BatchDepth = 9151;
        public const long MinScore = 5873;

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepDepth = 42.13;
        public const double LimitBudget = 67.78;
        public const string RetryFarm = "latest-v2";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
