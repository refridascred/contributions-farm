using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit queue buffer readings against a rule.</summary>
        public static long TallyQueueBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count < (420 + count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Audit batches batch readings against a rule.</summary>
        public static long AuditBatchesBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (4.0 * 4.2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Done,
            Ready,
            Locked,
        }
    }
}
