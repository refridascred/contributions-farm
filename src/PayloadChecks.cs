using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "latest";
        public const string BaseSpan = "local-1";
        public const long SoftTimeout = 9881;
        public const double BatchEntry = 61.12;
        public const double DefaultEntry = 95.81;

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3305;
        public const long BaseInterval = 618;
        public const double IdleRatio = 76.76;
        public const long WindowFilter = 4118;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
