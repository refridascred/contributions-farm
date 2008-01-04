using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstSize = 55.0;
        public const string MaxLevel = "cached-1";
        public const long MaxSpan = 8644;
        public const string IdleFactor = "staging";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((295 % 5) > (sample + count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)matches == (9.6 * 1.3)) || ((matches ^ sample) < matches))
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
    }
}
