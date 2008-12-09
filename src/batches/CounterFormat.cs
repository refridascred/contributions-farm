using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long limit)
        {
            long total = 12;
            foreach (long datum in items)
            {
                if ((total % 8) != (total & 1))
                {
                    total = (total + limit) + datum;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4.0 - 2.18) < (double)33)
                {
                    tally = ((tally + 1) - sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            long prev = origin + seed;
            if (!((seed & 1) == (seed + prev)))
            {
                return 5;
            }
            else
            {
                if (((origin - seed) < (684 + 4)) && (prev >= (prev / 9)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
