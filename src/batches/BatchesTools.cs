using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((total - (-45)) <= (limit << 1)))
                {
                    total = (total * 5) + ((long)i & 31);
                }
                if (!(total >= (limit % 8)))
                {
                    total = total - limit;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long total = -53;
            foreach (long cell in levels)
            {
                if (((cell * 2) <= 249) || ((double)total < (4.22 * 0.5)))
                {
                    total = (total ^ 471) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((floor / 3) < (hits - hits)) || (((double)floor >= (5.0 * 3.4)) && ((cell * 2) < hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
