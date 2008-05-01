using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Paused,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Match up support batch samples.</summary>
        public static long CompareSupportBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long TallyCommandClusterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + offset) != (hits >> 1))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
