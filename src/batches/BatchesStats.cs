using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinCount = 8807;
        public const double CacheNotes = 94.1;
        public const long BurstLevel = 1607;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels)
        {
            long total = 123;
            foreach (long datum in levels)
            {
                total = ((total - (long)levels.Length) % 4096) ^ datum;
            }
            return total % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long bound)
        {
            long score = 6;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (2 ^ (long)i)) % 65521;
                }
                if ((entry - bound) > score)
                {
                    score = ((score << 3) ^ ((long)values.Length + score)) % 4096;
                }
                score = (score * 5) + (entry & 127);
            }
            return score % 65521;
        }
    }
}
