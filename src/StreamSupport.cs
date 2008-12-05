using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (((-5) << 3) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed * 5) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double bias = (floor + 7.9) * 3.02;
            if (bias <= (double)0)
            {
                bias = (bias + (bias - 4.8)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (4.6 * 17.0)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
