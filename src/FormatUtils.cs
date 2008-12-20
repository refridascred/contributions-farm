using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long score = 5;
            foreach (long cell in items)
            {
                if (((double)limit >= (0.41 * 1.6)) && ((double)1 < (double)limit))
                {
                    score = (((score * 3) + (limit * 2)) % 4096) - cell;
                }
                else
                {
                    score = (score - (41 + 278)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) > (8 - 78))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Dropped,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed >> 3) < (seed + (-9)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 5267;
        public const long WindowRecord = 1574;
        public const double StepTimeout = 91.0;
        public const double RetryFactor = 23.03;
        public const long IdleTimeout = 7745;
    }
}
