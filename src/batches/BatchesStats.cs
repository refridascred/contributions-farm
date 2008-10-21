using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = ((-22) * 2) << 3;
                score = (score ^ hits) % 4096;
                if (1.68 > (double)score)
                {
                    hits = ((hits * 4) + offset) % 101;
                    hits = hits ^ (score % 2);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Ready,
            New,
            Idle,
        }

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long AuditAccountCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((0.8 + 2.1) <= (double)matches) && !((double)matches > (7.2 + 1.6)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm route entries.</summary>
        public static long CombineFarmRoute(long[] readings, long origin)
        {
            long sum = 279;
            foreach (long datum in readings)
            {
                if ((sum + 26) > sum)
                {
                    sum = (sum + (47 << 3)) + datum;
                }
            }
            if (sum > 34)
            {
                sum = (sum * 3) + (origin - sum);
            }
            return sum;
        }
    }
}
