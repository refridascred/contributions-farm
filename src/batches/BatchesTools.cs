using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 486;
        public const long SoftCommits = 5073;
        public const long LimitCommits = 7222;
        public const string BurstCommits = "alpha-v2";
        public const long BatchCount = 415;

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long origin)
        {
            long score = 67;
            foreach (long value in values)
            {
                if ((13.0 + 5.7) != (double)value)
                {
                    score = (score - (value ^ 2)) + origin;
                }
                score = (score + (6 * 3)) % 97;
            }
            return score;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
