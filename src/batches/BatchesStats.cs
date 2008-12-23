using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 478;
            foreach (long reading in items)
            {
                if (reading >= (reading * 3))
                {
                    state = ((state * 2) + (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen << 2) <= (value & 63))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((double)floor <= (double)count) && !((datum << 1) > (datum * 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Failed,
            Active,
        }
    }
}
