using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a stats order counter forward.</summary>
        public static long IterateStatsOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (origin / 2)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
