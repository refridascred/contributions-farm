using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((double)carry > (3.7 * 0.56))
                {
                    carry = (carry - (3 & 63)) ^ entry;
                }
                else
                {
                    carry = carry - (595 + carry);
                }
            }
            return carry;
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
