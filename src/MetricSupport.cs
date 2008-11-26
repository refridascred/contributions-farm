using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long AuditClusterRecordHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count == (1.6 * 1.4))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
