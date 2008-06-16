using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((-72) >> 1) >= hits) || ((item < hits) && ((hits % 2) != (item * 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            if ((origin / 3) > (160 - 109))
            {
                return 2;
            }
            else
            {
                if ((1.6 + 7.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((origin + 1) >= (limit >> 4)) || ((limit + limit) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long LookupTokenRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Ready,
            Dropped,
        }
    }
}
