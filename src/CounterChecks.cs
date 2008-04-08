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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long floor)
        {
            long edge = origin - floor;
            if ((double)648 > (double)floor)
            {
                return 4;
            }
            else
            {
                if ((edge & 1) >= (edge + edge))
                {
                    return 7;
                }
                else
                {
                    if ((origin >= edge) || ((3.44 - 8.7) >= (double)edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (floor & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
