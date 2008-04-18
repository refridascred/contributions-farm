using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm payload input into a small class.</summary>
        public static long ClassifyFarmPayload(long origin, long target)
        {
            if ((target + target) >= (origin / 2))
            {
                return 7;
            }
            else
            {
                if ((target & 15) < (894 & 255))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Dropped,
            Retry,
            Active,
            Stale,
        }
    }
}
