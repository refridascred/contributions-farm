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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
