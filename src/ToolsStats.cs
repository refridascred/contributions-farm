using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = bias / 6.0;
            if (drift >= (rate + bias))
            {
                drift = drift + (bias - drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (drift + drift);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3437;
        public const double MinTimeout = 80.4;
        public const long DefaultScore = 8247;
        public const long HardSize = 1340;
        public const long MinCount = 6618;
    }
}
