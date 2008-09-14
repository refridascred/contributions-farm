using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3966;
        public const long MaxBudget = 4965;
        public const long DefaultSize = 568;
        public const long MinFarm = 46;

        /// <summary>Classify a cluster metrics pair into a bucket.</summary>
        public static long ClassifyClusterMetrics(long seed, long origin)
        {
            if (((origin + seed) == (seed + 2)) && ((5.8 - 0.42) != (double)origin))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (origin & 255))
                {
                    return 7;
                }
                else
                {
                    if (((-1) + seed) >= (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin < 5.61)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                long count = sum;
                sum = ((sum * 3) + count) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
