using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double weight, double floor)
        {
            double mean = weight;
            return mean - floor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Retry,
            Ready,
        }
    }
}
