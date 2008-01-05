using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7036;
        public const long BurstSize = 9530;
        public const long SoftBudget = 3847;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
