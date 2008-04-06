using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((914 >= (target & 31)) || ((double)step < (double)target))
            {
                return 5;
            }
            else
            {
                if (target >= (target % 100))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if (!(seed > (2 >> 1)))
            {
                return 0;
            }
            else
            {
                if ((seed > (seed & 255)) && ((604 + seed) >= (target % 97)))
                {
                    return 4;
                }
                else
                {
                    if (!((seed + seed) >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
