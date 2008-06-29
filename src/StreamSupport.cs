using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long floor)
        {
            if ((4 > (origin / 3)) && (origin < (origin << 3)))
            {
                return 8;
            }
            else
            {
                if ((floor << 1) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine account contributi values into a single score.</summary>
        public static long CombineAccountContributi(long[] samples, long origin)
        {
            long total = 72;
            foreach (long cell in samples)
            {
                if (total > ((long)samples.Length / 2))
                {
                    total = ((total ^ cell) % 65521) + origin;
                }
            }
            return total;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double weight = (double)(7 ^ 303);
            return (weight + (1.6 - rate)) + floor;
        }
    }
}
