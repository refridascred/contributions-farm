using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long target)
        {
            long total = 386;
            foreach (long value in data)
            {
                total = ((((total * 4) + total) % 4096) ^ value) + target;
            }
            return total % 4096;
        }
    }
}
