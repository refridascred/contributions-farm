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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                acc = (acc - (acc - acc)) - reading;
            }
            if (acc > (-5))
            {
                acc = (acc * 2) + acc;
            }
            return acc;
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
