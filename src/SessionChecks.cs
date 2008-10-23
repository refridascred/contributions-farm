using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 8677;
        public const long SoftScore = 8862;
        public const string MaxWindow = "open";
        public const long RetrySpan = 8898;
        public const long IdleWindow = 3091;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 - 7.0) != (double)count)
                {
                    count = ((count + 1) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Synced,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series, long origin)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((double)item < 6.29)
                {
                    mark = (mark - (554 % 16)) + origin;
                }
                else
                {
                    mark = (mark ^ (item + 9)) % 97;
                }
            }
            return mark;
        }
    }
}
