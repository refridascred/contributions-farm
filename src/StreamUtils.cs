using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches != (double)13)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Dropped,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > (reading * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 58.03;
        public const long MaxGithubfarm = 145;
        public const long MinGithubfarm = 116;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
