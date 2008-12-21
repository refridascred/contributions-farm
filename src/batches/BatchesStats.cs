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

        /// <summary>Grade a batches payload value against two limits.</summary>
        public static long RankBatchesPayload(long bound, long seed)
        {
            long diff = bound + seed;
            if ((double)diff != (2.26 - 3.1))
            {
                return 7;
            }
            else
            {
                if (((diff << 1) > seed) || ((3 % 7) >= (bound + diff)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (5.8 - 7.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - bound) > (seed << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
