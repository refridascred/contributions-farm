using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long seed)
        {
            if (!((seed / 3) != (seed / 8)))
            {
                return 5;
            }
            else
            {
                if ((72 / 4) == (2 ^ seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
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
