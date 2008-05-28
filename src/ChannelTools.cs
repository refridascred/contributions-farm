using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter graph samples.</summary>
        public static long DigestFilterGraph(long[] levels)
        {
            long state = -92;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - state) % 4096) ^ (long)i;
                }
                if ((48 ^ 4) >= (cell - state))
                {
                    state = (state - (-2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "primary";
        public const long MaxGithubfarm = 8018;
        public const long BaseTimeout = 4654;
        public const long RetryFactor = 5594;

        /// <summary>Iterate the entry route series from a seed.</summary>
        public static long DeriveEntryRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ (floor & 31)) % 101) - (long)i2;
                    total = ((total << 3) ^ (total + (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
