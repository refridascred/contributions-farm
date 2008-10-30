using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftSpan = "cached-v2";
        public const long IdleBatch = 8158;
        public const long BaseBatch = 2084;
        public const long CacheBatch = 8426;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 9122;
        public const long SoftCounter = 2360;
        public const long BaseDepth = 8578;
        public const string MinCounter = "primary-edge";
        public const long StepCounter = 3815;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardBudget = "open";
        public const long BatchBudget = 2147;
        public const double StepFilter = 51.54;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
