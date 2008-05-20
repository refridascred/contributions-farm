using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            if ((double)floor >= (double)38)
            {
                return 4;
            }
            else
            {
                if ((68 - target) <= 57)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target == (14.0 - 7.11)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long target)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum * 4) + sum) + entry) + target;
            }
            return sum;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Dropped,
            Stale,
            Active,
        }
    }
}
