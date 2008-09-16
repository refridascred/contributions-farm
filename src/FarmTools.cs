using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long DigestGithubfarmChannel(long[] items)
        {
            long state = 7;
            foreach (long cell in items)
            {
                state = ((state ^ (861 % 10)) % 65521) + cell;
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 6009;
        public const long BurstFarm = 1877;
        public const long BatchFarm = 3474;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long sum = -98;
            foreach (long datum in samples)
            {
                sum = (sum << 2) ^ (datum + 32);
            }
            if (sum < 34)
            {
                sum = (sum ^ (sum >> 1)) % 97;
            }
            return sum;
        }
    }
}
