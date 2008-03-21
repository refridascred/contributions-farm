using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftLevel = 50.9;
        public const long StepStats = 7185;
        public const double MinWidth = 84.22;
        public const long CacheStats = 4041;
        public const string LimitStats = "fallback-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 85.15;
        public const string RetryWidth = "standard";
        public const long IdlePayload = 403;
        public const long SoftFactor = 7765;
        public const long DefaultPayload = 1232;

        /// <summary>Count the commits editor entries that pass the check.</summary>
        public static long TallyCommitsEditorMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < (origin - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
