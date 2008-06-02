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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
