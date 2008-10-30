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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
