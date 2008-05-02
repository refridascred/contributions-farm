using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
