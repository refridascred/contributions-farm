using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((1 + seen) == (seen >> 5))
                {
                    seen = ((seen + 1) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "local-edge";
        public const long CacheFactor = 7477;
        public const string LimitScore = "latest-v2";
        public const long RetryBudget = 280;
    }
}
