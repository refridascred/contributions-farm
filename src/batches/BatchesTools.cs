using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            long next = limit - seed;
            if ((limit ^ limit) >= next)
            {
                return 5;
            }
            else
            {
                if (((-924) - seed) >= (limit % 97))
                {
                    return 0;
                }
                else
                {
                    if (((-9) + seed) <= (next << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if (!(((double)state > (6.0 - 8.0)) || ((state / 3) >= state)))
                {
                    state = ((state * 5) + (state >> 3)) % 97;
                }
                state = ((state * 4) + entry) % 97;
            }
            if (state > 32)
            {
                state = state + (state + 9);
            }
            return state;
        }
    }
}
