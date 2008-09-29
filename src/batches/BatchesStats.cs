using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ ((long)i ^ 888);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = (state + limit) - cell;
            }
            return state;
        }
    }
}
