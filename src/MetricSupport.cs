using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            if (((double)step != (1.7 / 3.0)) && (offset > (step & 255)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 16))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Queued,
            Done,
            Failed,
        }
    }
}
