using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowRatio = 58.08;
        public const long SoftCommits = 273;
        public const double StepSpan = 25.74;
        public const double StepCommits = 39.29;
        public const double CacheCommits = 66.79;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Dropped,
            Active,
            Pending,
            Idle,
        }
    }
}
