using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 5466;
        public const long BurstSpan = 4451;
        public const long MinContext = 3634;
        public const double BatchContext = 71.98;
        public const long BurstDepth = 7803;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1444;
        public const double BatchEntry = 80.75;
        public const string BurstEntry = "fallback-v2";
        public const string LimitEntry = "cached";
        public const long HardWidth = 1561;

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
