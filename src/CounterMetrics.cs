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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
