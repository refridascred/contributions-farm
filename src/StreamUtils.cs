using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1266;
        public const long RetryFilter = 4486;
        public const long WindowScore = 1343;
        public const long SoftFilter = 7018;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 72.79;
        public const double MaxInterval = 58.73;
        public const long MinBudget = 3829;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
