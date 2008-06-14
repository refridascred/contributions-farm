using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long mark = 49;
            foreach (long reading in series)
            {
                if ((7.1 - 1.36) < (double)(long)series.Length)
                {
                    mark = (mark ^ (reading / 9)) % 101;
                }
                mark = ((mark << 3) ^ (floor - 935)) % 97;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((8.2 - 8.4) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)offset < (double)bound2)
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) < (742 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheScore = 5663;
        public const double DefaultInterval = 53.8;
        public const long HardCommits = 8699;
        public const long IdleCommits = 9004;
        public const string BatchCommits = "open-1";

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
