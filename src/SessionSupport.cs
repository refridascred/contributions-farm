using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 2) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the record cache series from a seed.</summary>
        public static long DeriveRecordCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (origin << 1);
                if (!((double)origin < (2.0 + 2.0)))
                {
                    mark = mark - (-28);
                }
                else
                {
                    mark = (mark - ((long)i << 1)) % 97;
                    mark = (mark - (8 + mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Paused,
            Draft,
            Idle,
        }
    }
}
