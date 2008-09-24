using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long total = 179;
            foreach (long cell in levels)
            {
                total = ((total ^ (offset << 1)) % 65521) + cell;
            }
            if (total > 676)
            {
                total = (total - (offset & 1)) % 255;
            }
            return total;
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
