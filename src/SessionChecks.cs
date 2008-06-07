using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (double)599)
            {
                mean = (mean + (double)57) - bias2;
            }
            else
            {
                mean = mean + (15.0 / 3.0);
            }
            return mean - 3.4;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
