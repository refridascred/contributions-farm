using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long origin)
        {
            long offset = floor ^ origin;
            if (!((offset ^ offset) <= (floor % 60)))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) <= (origin / 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
