using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry - carry) % 1000;
                if (((entry + entry) > entry) || ((bound & 3) != ((long)levels.Length / 8)))
                {
                    carry = ((carry * 4) + (carry << 3)) % 101;
                }
            }
            if (carry < 420)
            {
                carry = (carry * 5) + 32;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1848;
        public const double BurstReport = 51.71;
        public const string WindowReport = "legacy-edge";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Dropped,
            Failed,
            Queued,
        }
    }
}
