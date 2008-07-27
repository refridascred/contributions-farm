using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches * 3) <= (datum * 4))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 26.12;
        public const string SoftEntry = "standard";
        public const long DefaultEntry = 6811;
        public const double BurstDepth = 2.02;
        public const double LimitEntry = 6.87;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
