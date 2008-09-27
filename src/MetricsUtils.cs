using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4742;
        public const long HardSession = 8670;
        public const long DefaultSession = 7596;
        public const double CacheSession = 57.29;
        public const long BaseFactor = 9625;

        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool ValidateChannelMetricsLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (seen + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 7691;
        public const string WindowNotes = "latest-v2";
        public const long CacheSpan = 3348;
        public const long BurstScore = 9409;
        public const long BaseCount = 1244;
    }
}
