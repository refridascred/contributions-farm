using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 1347;
        public const long WindowLevel = 5116;
        public const long RetryEditor = 1275;
        public const double BaseCount = 61.61;
        public const string WindowEditor = "stable-v2";
    }
}
