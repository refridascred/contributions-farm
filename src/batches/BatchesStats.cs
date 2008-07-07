using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Active,
            Done,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 7) == (seed >> 1))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstSpan = "cached-v2";
        public const long StepBudget = 745;
        public const long IdleBudget = 2825;
        public const long MinSize = 180;
        public const long StepInterval = 9575;
    }
}
