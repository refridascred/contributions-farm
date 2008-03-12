using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 503;
        public const string IdleLevel = "fallback-1";
        public const double CachePayload = 35.37;
        public const double WindowPayload = 5.42;

        /// <summary>Validate checks metric readings against a bound.</summary>
        public static bool CheckChecksMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
