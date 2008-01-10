using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            long span = offset - limit;
            if ((span + 545) < (7 ^ 340))
            {
                return 6;
            }
            else
            {
                if (((34 - offset) == (limit + limit)) || (2 > (span + offset)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (value + 54))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double AdjustProfileChecks(double gain, double bias)
        {
            double scale = (2.9 - 1.9) - gain;
            if (scale < (double)0)
            {
                scale = (scale + (gain / 5.0)) + bias;
            }
            return scale - scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinFactor = 8876;
        public const long HardProfile = 4948;
        public const long BurstSize = 4893;
    }
}
