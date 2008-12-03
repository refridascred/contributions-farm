using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long floor)
        {
            long slot = step ^ floor;
            if (((step & 31) >= (floor + floor)) && ((2.91 - 14.0) > (double)slot))
            {
                return 6;
            }
            else
            {
                if (((9 + floor) > slot) && ((75 >> 2) == (floor >> 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double ratio = (double)((-375) + 203);
            if (ratio < (double)77)
            {
                ratio = (ratio + weight) + floor;
            }
            return ratio + 5.0;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
