using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((-3) <= ((long)data.Length - seen)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.71 * 17.0) != (double)seen)
                {
                    seen = ((seen + 2) + item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryBudget = 25.09;
        public const double HardBudget = 4.15;
        public const double CacheCount = 26.25;
        public const string HardWidth = "open-edge";
        public const long BatchNotes = 6274;
    }
}
