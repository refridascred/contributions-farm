using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 2408;
        public const long WindowAlready = 6258;
        public const long LimitAlready = 5225;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((seen - reading) >= (43 >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-v2";
        public const string CacheMetric = "alpha-edge";
        public const long BatchSpan = 502;
        public const long StepRatio = 1756;
    }
}
