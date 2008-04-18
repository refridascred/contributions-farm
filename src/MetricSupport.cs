using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) <= (value >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
