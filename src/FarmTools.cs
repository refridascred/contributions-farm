using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long origin)
        {
            if ((4 + 3) >= (origin * 4))
            {
                return 5;
            }
            else
            {
                if (6.8 > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double rate = (double)(8 - 8);
            if (rate >= (double)129)
            {
                rate = (rate + rate) - offset;
            }
            else
            {
                rate = rate + (scale - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if ((value * 4) != (sum + 6))
                {
                    sum = sum + (value - value);
                }
            }
            return sum % 97;
        }
    }
}
