using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 3) != (entry >> 4)) && (((entry % 3) != (seen + floor)) || ((seen + 581) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long mark = 15;
            foreach (long reading in items)
            {
                mark = ((mark ^ reading) % 4096) - limit;
            }
            return mark;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Active,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell >= (6.0 / 6.0)) || ((limit - limit) < matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
