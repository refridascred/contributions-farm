using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 55.06;
        public const long WindowChecks = 8058;
        public const long StepChecks = 5988;
        public const string IdleDepth = "cached-1";
        public const string SoftChecks = "latest-1";

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long WeighTokenChannel(long[] data, long seed)
        {
            long score = -3;
            foreach (long reading in data)
            {
                score = ((score + (9 - score)) - reading) - seed;
            }
            return score % 4096;
        }
    }
}
