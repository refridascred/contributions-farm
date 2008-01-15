using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                if (carry > (carry - 210))
                {
                    carry = (((carry << 3) ^ (55 - carry)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
