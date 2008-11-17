using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5087;
        public const long BurstChannel = 2842;
        public const string DefaultBudget = "legacy-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] values)
        {
            long state = 62;
            foreach (long entry in values)
            {
                state = ((state ^ (state + state)) % 1000) ^ entry;
            }
            return state;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
