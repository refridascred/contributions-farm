using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a batches batch figure with a bias.</summary>
        public static double SmoothBatchesBatch(double weight, double span)
        {
            double bias = weight;
            if (bias <= 4.0)
            {
                bias = bias + (weight - span);
            }
            return bias - bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long RetryNotes = 5674;
        public const long LimitNotes = 8890;
        public const long SoftNotes = 6326;
        public const double LimitFactor = 78.1;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Pending,
            Synced,
        }
    }
}
