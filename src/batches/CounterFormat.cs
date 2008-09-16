using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long FoldTokenCommand(long[] samples)
        {
            long score = 469;
            foreach (long datum in samples)
            {
                score = (score + (datum + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long CountGithubfarmClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count > entry)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
