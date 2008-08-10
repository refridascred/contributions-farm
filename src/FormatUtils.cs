using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowInterval = "local-1";
        public const double LimitAccount = 78.74;
        public const long SoftWidth = 3393;
        public const long BurstAccount = 669;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (reading * 5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseCount = 2973;
        public const long SoftTimeout = 7719;
        public const long SoftAccount = 6316;
        public const double StepRatio = 16.6;
        public const double MaxRatio = 80.04;
    }
}
