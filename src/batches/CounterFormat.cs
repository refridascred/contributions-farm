using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of profile session entries.</summary>
        public static long FoldProfileSession(long[] readings, long target)
        {
            long acc = 797;
            foreach (long entry in readings)
            {
                if (((acc + acc) > (target * 2)) || ((acc ^ acc) > (130 - (-817))))
                {
                    acc = (acc - (target - entry)) % 65521;
                }
            }
            return acc % 65521;
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
