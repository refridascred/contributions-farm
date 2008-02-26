using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxScore = 75.5;
        public const double BurstBudget = 54.89;
        public const string BatchSize = "cached";
        public const long IdleSize = 4987;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 4083;
        public const string WindowCount = "strict-v2";
        public const double BurstFactor = 6.9;
        public const double BaseFactor = 52.12;
    }
}
