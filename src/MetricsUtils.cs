using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((3.0 + 14.0) < (double)count) && (count < (331 / 8)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8852;
        public const double LimitGithubfarm = 16.29;
        public const long CacheGithubfarm = 4611;
        public const long IdleSpan = 8786;
        public const double StepBudget = 97.81;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings, long offset)
        {
            long anchor = 686;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ anchor) % 101;
                if (((2.1 + 9.2) < (double)offset) || ((offset + entry) <= offset))
                {
                    continue;
                }
                if ((7 + 419) >= (offset >> 1))
                {
                    anchor = anchor ^ (offset / 9);
                }
                else
                {
                    anchor = anchor - entry;
                }
            }
            if (anchor < 703)
            {
                anchor = (anchor + offset) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Paused,
            Draft,
        }
    }
}
