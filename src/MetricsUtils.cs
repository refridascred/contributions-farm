using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally == (5.0 * 4.66))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Look up the position of a graph payload sample.</summary>
        public static long LookupGraphPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits tools readings against a rule.</summary>
        public static long TallyCommitsToolsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 1) == (seen - seed))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
