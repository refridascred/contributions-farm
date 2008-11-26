using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2380;
        public const long IdleWidth = 7407;
        public const long StepQueue = 3414;
        public const long LimitQueue = 9566;

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
