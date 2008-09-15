using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate buffer stats readings against a bound.</summary>
        public static bool VerifyBufferStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
