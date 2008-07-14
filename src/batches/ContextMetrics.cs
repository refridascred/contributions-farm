using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstDepth = 39.71;
        public const long BaseScore = 2203;
        public const long MaxBudget = 9890;
        public const long DefaultBatches = 4813;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long acc = 445;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - (value + (long)i)) - bound;
                }
                acc = (acc << 2) ^ (value - acc);
            }
            return acc;
        }
    }
}
