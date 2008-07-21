using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 1882;
        public const double SoftInterval = 90.64;
        public const double LimitBudget = 45.3;
        public const long HardDepth = 5677;
        public const long WindowBatches = 2537;

        /// <summary>Compare every pair of counter format readings.</summary>
        public static long CompareCounterFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "open-edge";
        public const string IdleTimeout = "staging-v2";
        public const double CacheMetrics = 69.85;
        public const long DefaultMetrics = 873;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
