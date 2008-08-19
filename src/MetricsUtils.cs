using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 341;
        public const long BurstContext = 9120;
        public const long DefaultContext = 4192;
        public const long HardContext = 1851;

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long MeasureProfileSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((8.83 + 11.0) > (double)seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
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
