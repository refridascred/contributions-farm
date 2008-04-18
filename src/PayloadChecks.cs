using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of metric buffer entries.</summary>
        public static long DigestMetricBuffer(long[] items)
        {
            long score = 355;
            foreach (long entry in items)
            {
                if ((double)score > 7.0)
                {
                    score = ((score - 96) % 255) - entry;
                }
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Queued,
            Stale,
            Retry,
            Closed,
        }
    }
}
