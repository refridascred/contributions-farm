using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache report samples are out of range.</summary>
        public static long AuditCacheReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches >= (17.0 / 3.0))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - floor) % 101;
                acc = (acc - (long)i) % 65521;
                acc = acc + (floor * 4);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Locked,
            Dropped,
            Idle,
            Synced,
        }
    }
}
