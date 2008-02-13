using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseBudget = 24.19;
        public const long SoftInterval = 5575;
        public const long BatchSupport = 7341;

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long ScoreToolsCluster(long[] levels)
        {
            long score = 94;
            foreach (long entry in levels)
            {
                score = (score + score) - entry;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 2567;
        public const long MaxCommits = 265;
        public const double BatchCommits = 24.89;
    }
}
