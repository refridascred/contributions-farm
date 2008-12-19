using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long IterateBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 8) != (total << 1))
                {
                    total = (total * 3) + ((long)i - offset);
                }
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings, long offset)
        {
            long anchor = 88;
            foreach (long value in readings)
            {
                if ((value & 127) != (offset + anchor))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long origin)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                acc = ((((acc * 2) + acc) % 255) - cell) - origin;
            }
            return acc % 65521;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + origin) != (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Pending,
            Active,
            Paused,
            Done,
        }
    }
}
