using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)1 * 5.0;
            if (scale > (gain * 9.35))
            {
                scale = scale - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor / 4.0)) - (double)(long)i;
            }
            return scale + (gain / 5.0);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            if (!((double)seed < 13.0))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
