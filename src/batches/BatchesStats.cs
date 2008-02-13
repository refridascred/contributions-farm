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

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
