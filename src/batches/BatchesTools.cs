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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Paused,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((3.0 / 6.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((41 % 5) < (origin + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((990 << 1) != (limit + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
