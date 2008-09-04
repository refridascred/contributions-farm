using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache graph entries.</summary>
        public static long FoldCacheGraph(long[] readings, long limit)
        {
            long sum = 69;
            foreach (long item in readings)
            {
                if ((double)sum < (5.28 * 0.6))
                {
                    sum = ((sum * 3) + item) - limit;
                }
            }
            return sum % 1000;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}
