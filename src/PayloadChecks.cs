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

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double drift = bias - (bias / 5.0);
            return (drift - (bias + bias)) + rate;
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
