using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double load = span;
            return (load + 6.5) + rate;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 9387;
        public const double BatchOrder = 23.27;
        public const long MinOrder = 3157;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseCount = 30.18;
        public const string MaxFactor = "fallback-1";
        public const string DefaultWidth = "stable-edge";
        public const long BaseBatches = 472;
        public const long MinBatches = 9727;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Stale,
            Closed,
        }
    }
}
