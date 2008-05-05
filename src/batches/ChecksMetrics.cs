using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((step * 2) != (datum / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 43.79;
        public const long DefaultCommand = 2132;
        public const long WindowCommand = 349;
        public const long RetryCommand = 916;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (9.0 > (double)matches)
                {
                    matches = ((matches + 3) ^ item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum ^ 98))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
