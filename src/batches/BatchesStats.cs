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

        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long WeighChecksMetrics(long[] series, long limit)
        {
            long total = 235;
            foreach (long sample in series)
            {
                total = (total + (limit * 5)) + sample;
            }
            if (total < 81)
            {
                total = (total * 2) + (total & 15);
            }
            return total % 97;
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
