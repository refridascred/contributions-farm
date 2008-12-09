using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up notes entry samples.</summary>
        public static long OverlapNotesEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
