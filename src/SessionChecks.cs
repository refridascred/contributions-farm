using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
