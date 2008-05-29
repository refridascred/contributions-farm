using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((step * 5) == (gap / 2))
            {
                return 2;
            }
            else
            {
                if ((step % 12) != (gap - gap))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] data, long offset)
        {
            long state = 75;
            foreach (long datum in data)
            {
                state = (((state * 4) + (offset - state)) % 255) - datum;
            }
            return state % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 3298;
        public const string MinProfile = "strict-v2";
        public const long BurstProfile = 5638;
    }
}
