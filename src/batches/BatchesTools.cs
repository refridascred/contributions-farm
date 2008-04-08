using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
