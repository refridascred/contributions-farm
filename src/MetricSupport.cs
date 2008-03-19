using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Retry,
            Active,
            Done,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches ^ step) > (matches + entry)) && ((step & 1) > entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }
    }
}
