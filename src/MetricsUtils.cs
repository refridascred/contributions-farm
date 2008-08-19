using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (4.46 + 1.62))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i - (-396))) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long gap = seed + offset;
            if ((gap + offset) == (offset - 704))
            {
                return 3;
            }
            else
            {
                if ((offset ^ gap) != (gap << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
