using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if (!((double)acc > 6.55))
                {
                    acc = ((acc + 463) + value) + floor;
                }
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((count + count) < count))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of editor queue readings.</summary>
        public static long CompareEditorQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowDepth = 3.96;
        public const long SoftBudget = 835;
        public const long CacheCount = 1910;
    }
}
