using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 4870;
        public const long BurstBudget = 1995;
        public const double RetryDepth = 41.45;
        public const string SoftOrder = "standard-1";

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double weight = 0.4 * 5.6;
            if (weight <= floor)
            {
                weight = weight - (double)8;
            }
            else
            {
                weight = weight - (bias + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (bias * 1.7);
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double weight, double floor)
        {
            double mean = weight;
            return mean - floor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (8 < (cur / 3))
            {
                return 2;
            }
            else
            {
                if ((double)cur >= (5.64 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
