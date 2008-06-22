using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Retry,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading & 7) > (54 + reading)) || ((110 * 2) < reading)) && (count > (count * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
