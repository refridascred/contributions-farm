using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Dropped,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long score = 33;
            foreach (long item in values)
            {
                if (score < (score / 5))
                {
                    score = (((score ^ (score + 629)) % 4096) ^ item) + bound;
                }
            }
            return score;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target / 6) > (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
