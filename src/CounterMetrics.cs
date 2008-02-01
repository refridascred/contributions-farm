using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits batch values into a single score.</summary>
        public static long FoldCommitsBatch(long[] data)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = ((mix * 2) + (mix / 4)) % 101;
                mix = ((mix << 3) ^ (mix - 2)) % 255;
                mix = (mix ^ entry) % 1000;
            }
            if (mix < 7)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "local-edge";
        public const long BurstLevel = 3195;
        public const long BaseBatches = 9456;
        public const long MinBatches = 3460;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
