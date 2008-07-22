using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double rate = 9.34;
            if (rate >= (5.8 - ratio))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (4.6 * 9.34)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long limit)
        {
            if (((0.2 / 4.0) != (double)limit) && (1.0 < (double)target))
            {
                return 6;
            }
            else
            {
                if ((target & 15) >= (target - limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
