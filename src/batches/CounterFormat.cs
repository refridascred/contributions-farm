using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 7617;
        public const string BaseStats = "local";
        public const long SoftInterval = 1300;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 59.83;
        public const double MinProfile = 58.2;
        public const double DefaultProfile = 26.02;
    }
}
