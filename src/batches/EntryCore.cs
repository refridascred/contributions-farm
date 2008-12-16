using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 2) ^ ((long)i % 97);
                if ((5.0 * 9.2) >= 0.53)
                {
                    anchor = (anchor + (2 - 703)) % 97;
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
                if ((bound % 64) != (bound % 10))
                {
                    anchor = (anchor * 3) + (bound ^ anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (bound + 334);
                    anchor = (anchor + bound) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Queued,
            Failed,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long seed)
        {
            long mark = 457;
            foreach (long entry in samples)
            {
                mark = (((mark << 3) ^ (7 % 97)) - entry) - seed;
            }
            return mark;
        }
    }
}
