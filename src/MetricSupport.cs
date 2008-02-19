using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long state = 182;
            foreach (long datum in data)
            {
                state = (state ^ 773) - datum;
                if (limit < (limit >> 4))
                {
                    state = ((state * 5) + (state * 2)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (state >> 2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((4 ^ entry) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
