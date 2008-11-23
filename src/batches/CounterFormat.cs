using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long limit)
        {
            if (((limit - limit) == (target >> 4)) || ((limit / 9) == (target - limit)))
            {
                return 7;
            }
            else
            {
                if ((13.0 / 2.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
