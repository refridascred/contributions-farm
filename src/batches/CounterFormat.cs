using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a command batch value against two limits.</summary>
        public static long BucketCommandBatch(long bound, long seed)
        {
            if (bound >= (bound + 867))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift + 1.0)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
