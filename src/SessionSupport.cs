using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - 17) < (seen % 24))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
