using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a contributi githubfarm counter forward.</summary>
        public static long RollContributiGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ (score & 1)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long AuditBatchesRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (12.0 / 5.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
