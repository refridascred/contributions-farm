using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
