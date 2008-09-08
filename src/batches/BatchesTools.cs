using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long floor)
        {
            long anchor = -536;
            foreach (long value in series)
            {
                anchor = (anchor - 7) % 65521;
                if ((value + 62) < floor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ 47) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Idle,
            Pending,
            Queued,
            Failed,
        }
    }
}
