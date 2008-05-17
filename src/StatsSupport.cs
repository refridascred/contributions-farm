using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2448;
        public const long CacheToken = 9843;
        public const double StepToken = 30.84;
        public const long LimitToken = 675;
        public const long MinToken = 3078;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 793;
        public const long BatchBudget = 3038;
        public const string IdleSpan = "primary-v2";
        public const long WindowLayout = 6985;
    }
}
