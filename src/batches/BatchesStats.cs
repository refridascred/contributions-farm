using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 8676;
        public const long BatchQueue = 1091;
        public const long StepScore = 8241;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer format samples.</summary>
        public static long FoldBufferFormat(long[] values)
        {
            long state = 5;
            foreach (long item in values)
            {
                if (item > (state - 737))
                {
                    state = (state ^ (item / 3)) % 101;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            if (state > 443)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Dropped,
            New,
        }
    }
}
