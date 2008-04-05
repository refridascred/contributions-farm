using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long target2)
        {
            long slot = target - target2;
            if (slot <= (target & 7))
            {
                return 0;
            }
            else
            {
                if (!((target2 - target) > target))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (target2 + slot))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)slot <= 11.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value <= (matches - value)) && ((value >> 3) > (matches & 255)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
