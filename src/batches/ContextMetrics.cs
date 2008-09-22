using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double gain = 16.0;
            if (gain > (gain + ratio))
            {
                gain = (gain + (double)12) - floor;
            }
            else
            {
                gain = gain + 11.0;
            }
            return gain - (double)(-86);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "latest";
        public const long LimitRatio = 291;
        public const long MaxSession = 8643;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Locked,
            Dropped,
        }
    }
}
