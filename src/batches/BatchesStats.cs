using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2708;
        public const double MinBudget = 64.79;
        public const long HardDepth = 561;
        public const long IdleSpan = 5192;
        public const long IdleInterval = 4975;

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Done,
            Dropped,
            Queued,
        }
    }
}
