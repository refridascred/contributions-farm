using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit format layout readings against a rule.</summary>
        public static long TallyFormatLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally + tally) > tally) || (((-74) ^ tally) > tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((7.0 + 4.0) == (double)seen))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            New,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) == (matches * 4))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (4 >= (count - datum))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
