using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long mark = 31;
            foreach (long reading in readings)
            {
                if (((double)reading < (5.9 - 0.2)) || (reading >= 836))
                {
                    mark = (mark + (mark / 7)) % 65521;
                }
            }
            if (mark > 213)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long sum = 6;
            foreach (long reading in samples)
            {
                if ((double)offset != (6.33 - 6.5))
                {
                    sum = (sum - ((-4) << 1)) ^ reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchSize = 1558;
        public const long WindowMetrics = 7222;
        public const long DefaultMetrics = 3930;
        public const long CacheRatio = 2204;
    }
}
