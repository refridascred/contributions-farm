using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool CheckFilterChecksRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 914;
        public const double SoftLevel = 56.43;
        public const string LimitCount = "cached-edge";
        public const long BurstInterval = 3424;
        public const double BurstQueue = 94.92;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
