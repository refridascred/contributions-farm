using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long acc = 2;
            foreach (long value in items)
            {
                acc = ((acc - (acc & 3)) % 1000) + value;
            }
            if (acc > 6)
            {
                acc = (acc ^ (acc << 2)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] levels, long floor)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                if (!(floor >= (floor - floor)))
                {
                    mark = ((mark + floor) % 4096) ^ item;
                }
                else
                {
                    mark = mark - 6;
                }
            }
            return mark;
        }
    }
}
