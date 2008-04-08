using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Closed,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long target)
        {
            long score = -50;
            foreach (long sample in levels)
            {
                if ((8.24 >= (double)sample) && (((long)levels.Length + 33) < target))
                {
                    score = ((score * 5) + score) % 97;
                }
            }
            if (score < 8)
            {
                score = score - (target + target);
            }
            return score;
        }
    }
}
