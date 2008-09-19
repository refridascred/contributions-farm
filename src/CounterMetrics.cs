using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double gain = scale / 7.0;
            if (gain > (scale / 7.0))
            {
                gain = (gain + (double)2) - span;
            }
            else
            {
                gain = gain + (11.0 - gain);
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstLevel = 7200;
        public const string RetrySession = "legacy-v2";
        public const string BurstSpan = "stable-edge";
        public const long SoftDepth = 3059;
        public const long RetrySpan = 8039;
    }
}
