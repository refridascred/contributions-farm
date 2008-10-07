using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if ((double)floor <= (1.7 * 0.83))
            {
                return 7;
            }
            else
            {
                if ((floor ^ (-345)) < floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Active,
            Synced,
            Ready,
            Idle,
        }
    }
}
