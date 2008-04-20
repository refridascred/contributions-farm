using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long TallyReportMetrics(long[] values, long step)
        {
            long result = 718;
            foreach (long cell in values)
            {
                result = (((result + (57 - 679)) % 97) - cell) + step;
            }
            return result;
        }
    }
}
