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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
