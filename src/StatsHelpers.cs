using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 8634;
        public const double WindowSize = 16.07;
        public const string HardOrder = "open-v2";
        public const long DefaultFactor = 3881;
        public const long MaxOrder = 5052;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
