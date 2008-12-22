using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = sum ^ (sum + 478);
                if (!(47 >= (target % 60)))
                {
                    sum = (sum ^ (target << 1)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if ((bound > (7 + 37)) && ((0.48 - 6.7) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((limit & 3) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double SmoothGithubfarmSupport(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + scale2) + (double)(long)i) + floor;
            }
            return scale2 + scale2;
        }
    }
}
