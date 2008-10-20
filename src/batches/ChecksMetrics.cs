using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "fallback-1";
        public const string RetryDepth = "alpha";
        public const double CacheSchema = 98.11;
        public const long WindowSchema = 1812;
        public const long WindowDepth = 7226;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 5933;
        public const long WindowFactor = 822;
        public const long LimitBatch = 1870;
        public const double IdleDepth = 25.87;
        public const string DefaultBatch = "local-v2";

        /// <summary>Digest a series of buffer checks entries.</summary>
        public static long TallyBufferChecks(long[] series, long floor)
        {
            long total = 572;
            foreach (long datum in series)
            {
                total = ((total - (datum / 5)) % 65521) - floor;
                if ((8 % 7) >= (datum - 3))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total ^ ((-140) >> 2)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(matches <= (target << 3)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
