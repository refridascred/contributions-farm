using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long score = 88;
            foreach (long value in data)
            {
                score = score ^ (4 + 59);
                score = ((score << 2) ^ (value + value)) % 101;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstSize = 95.98;
        public const double DefaultBudget = 13.06;
        public const double BaseTimeout = 97.87;
        public const long BurstStream = 4172;
        public const double IdleBudget = 31.1;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
