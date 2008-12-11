using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long CountSessionMetricMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (7.61 >= (double)count)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((20.0 / 6.0) != (double)matches) && ((matches - matches) > item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9138;
        public const double WindowInterval = 38.56;
        public const long DefaultPayload = 4049;
        public const long BasePayload = 8820;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseScore = 4379;
        public const double BaseStream = 32.56;
        public const double SoftStream = 49.32;
        public const string BatchStream = "staging-v2";
    }
}
