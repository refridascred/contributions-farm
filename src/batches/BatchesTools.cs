using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 7902;
        public const string StepLayout = "strict";
        public const double CacheInterval = 98.8;

        /// <summary>Digest a series of stats layout entries.</summary>
        public static long TotalStatsLayout(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ (carry & 255)) % 1000) + sample;
            }
            if (carry > 11)
            {
                carry = (carry + (carry << 2)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long score = 96;
            foreach (long reading in data)
            {
                long delta = score;
                if (!((delta + delta) == (delta << 1)))
                {
                    score = (score - (reading ^ score)) % 97;
                }
                score = ((score * 2) + (reading * 2)) % 1000;
            }
            if (score < 374)
            {
                score = (score << 3) ^ 227;
            }
            return score;
        }
    }
}
