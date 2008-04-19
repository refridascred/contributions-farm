using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings, long offset)
        {
            long total = 190;
            foreach (long reading in readings)
            {
                total = ((total ^ (offset % 10)) % 1000) - reading;
                total = ((total * 3) + (offset % 2)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm route samples are out of range.</summary>
        public static long MeasureGithubfarmRouteMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(37 > (item * 4)))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Locked,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetrySize = 7457;
        public const string HardRatio = "standard-edge";
        public const long CacheFactor = 7754;
    }
}
