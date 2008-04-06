using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate tools support readings against a bound.</summary>
        public static bool GuardToolsSupportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long CountMetricReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((8.0 - 2.0) < (double)sample) || ((seen ^ sample) >= sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 55.41;
        public const string LimitCommits = "standard";
        public const long SoftSpan = 3943;
        public const long HardRatio = 7144;
    }
}
