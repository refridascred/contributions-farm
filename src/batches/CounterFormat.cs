using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 5557;
        public const long DefaultChannel = 5947;
        public const long HardBudget = 245;
        public const string IdleDepth = "stable-v2";
        public const long BatchChannel = 4100;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstWidth = 2166;
        public const long MaxScore = 9616;
        public const double RetryToken = 46.84;
        public const long WindowToken = 3755;
    }
}
