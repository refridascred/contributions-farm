using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long step)
        {
            long sum = 586;
            foreach (long item in levels)
            {
                sum = sum ^ (782 - item);
                sum = (sum + (sum + step)) % 255;
            }
            return sum % 65521;
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
