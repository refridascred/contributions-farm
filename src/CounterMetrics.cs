using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LocateFarmFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 3969;
        public const double LimitWidth = 9.37;
        public const long IdleRatio = 1076;
        public const long BatchGithubfarm = 8102;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - count) != (long)samples.Length)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
