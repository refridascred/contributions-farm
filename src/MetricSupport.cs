using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long BucketClusterLayout(long limit, long floor)
        {
            long slot = limit + floor;
            if (((double)slot > (2.8 * 4.69)) && ((limit % 2) > (floor * 2)))
            {
                return 1;
            }
            else
            {
                if (!((90 & 1) >= slot))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long offset)
        {
            if (offset < (offset + step))
            {
                return 1;
            }
            else
            {
                if (!(79 < (step * 5)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
