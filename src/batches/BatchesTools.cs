using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long next = bound + offset;
            if ((bound > (bound - offset)) && ((9 >> 4) >= (offset * 4)))
            {
                return 5;
            }
            else
            {
                if (bound <= (offset + bound))
                {
                    return 2;
                }
                else
                {
                    if ((next / 9) < (3 ^ next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9333;
        public const long BurstSpan = 6312;
        public const double BurstInterval = 88.62;
    }
}
