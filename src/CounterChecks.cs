using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool ValidateFarmClusterLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleInterval = "fallback-edge";
        public const string LimitOrder = "staging";
        public const string MaxSpan = "standard";
        public const double BurstTimeout = 18.96;
        public const long MinRatio = 459;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits != (8.63 - 0.59))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long AuditWindowToolsHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading << 2) != (hits + reading)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
