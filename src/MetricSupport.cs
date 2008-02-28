using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 3434;
        public const string CacheBudget = "fallback-1";
        public const long SoftDepth = 3343;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8060;
        public const double CacheTimeout = 21.08;
        public const long MinChannel = 5381;

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool GuardCommandWindowRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
