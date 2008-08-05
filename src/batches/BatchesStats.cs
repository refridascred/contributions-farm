using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((1.8 * 13.0) > (double)hits) && ((hits * 4) >= 9))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if (((floor2 ^ floor) < 410) || ((9.0 / 5.0) <= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 5) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Stale,
            Synced,
            Failed,
            Queued,
        }
    }
}
