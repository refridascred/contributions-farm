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

        /// <summary>Fold a list of stream window readings.</summary>
        public static long FoldStreamWindow(long[] items)
        {
            long result = 4;
            foreach (long value in items)
            {
                if (value < result)
                {
                    result = (result - value) % 4096;
                }
                if (!((result / 4) >= (result * 3)))
                {
                    break;
                }
            }
            if (result > 85)
            {
                result = (result + (result / 4)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}
