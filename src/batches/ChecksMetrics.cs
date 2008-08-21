using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 9477;
        public const double RetryStats = 37.68;
        public const double BurstLevel = 44.78;
        public const double WindowStats = 55.59;
        public const long CacheSize = 4545;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 3661;
        public const long CacheWidth = 9820;
        public const string IdleFilter = "strict-edge";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((item * 2) >= item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
