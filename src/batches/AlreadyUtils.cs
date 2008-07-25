using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstLevel = 1237;
        public const double BaseDepth = 39.2;
        public const string IdleSize = "staging-edge";
        public const long HardBudget = 3770;
        public const long MinMetrics = 8120;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every session format entry stays within the limit.</summary>
        public static bool VerifySessionFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((seed < (item % 2)) || ((item ^ 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long AuditCommitsTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (77 >= (bound << 3))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
