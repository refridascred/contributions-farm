using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 1480;
        public const string MaxCache = "local-edge";
        public const long IdleCache = 452;
        public const double HardInterval = 82.74;
        public const long BurstCache = 7054;

        /// <summary>Define order limits and defaults.</summary>
        public const double StepBudget = 7.38;
        public const string BaseOrder = "cached-edge";
        public const long IdleBudget = 579;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
