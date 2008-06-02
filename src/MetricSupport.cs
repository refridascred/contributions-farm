using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (74 > (seen - limit))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitSize = 40.77;
        public const long BurstDepth = 7870;
        public const double BatchFormat = 40.77;
        public const long IdleFormat = 3745;
        public const long BatchLevel = 2284;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
