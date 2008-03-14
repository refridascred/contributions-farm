using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Done,
            Failed,
            New,
            Synced,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) > datum) && (((7.31 * 6.3) >= (double)step) && ((double)datum >= (7.61 * 3.2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
