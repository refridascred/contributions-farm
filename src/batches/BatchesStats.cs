using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ 257) + cell) - step;
            }
            return mix % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftLevel = "open-v2";
        public const string MaxBudget = "latest-edge";
        public const long RetrySchema = 2798;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9573;
        public const double DefaultProfile = 18.15;
        public const long StepLevel = 2464;
        public const long MaxProfile = 4837;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
