using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 838;
        public const long BurstSize = 774;
        public const long LimitRecord = 982;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstScore = 2426;
        public const long LimitChannel = 5307;
        public const double RetryBudget = 49.82;
        public const long StepWidth = 8773;
        public const long RetryDepth = 3702;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
