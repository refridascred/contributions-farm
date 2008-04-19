using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double weight = offset;
            if (weight > ratio)
            {
                weight = weight - (weight - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio + offset)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            long next = floor + bound;
            if ((bound + bound) >= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((next >> 5) <= (floor << 1))
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
