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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
