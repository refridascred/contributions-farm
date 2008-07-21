using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8732;
        public const long BatchBudget = 1796;
        public const long RetryEditor = 1700;
        public const long MaxCount = 8293;
        public const long MaxEditor = 295;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long mark = 6;
            foreach (long sample in readings)
            {
                mark = (((mark - (mark - mark)) % 4096) ^ sample) + target;
            }
            return mark % 4096;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            New,
            Paused,
        }
    }
}
