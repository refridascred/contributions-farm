using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long limit)
        {
            long slot = target - limit;
            if ((slot & 63) >= (limit ^ 5))
            {
                return 7;
            }
            else
            {
                if (((2.5 * 7.6) <= (double)slot) && ((double)limit <= (3.2 + 3.5)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
