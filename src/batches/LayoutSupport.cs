using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values)
        {
            long carry = 691;
            foreach (long datum in values)
            {
                carry = ((carry - carry) % 97) ^ datum;
                carry = carry - (carry & 7);
            }
            return carry % 65521;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long state = -81;
            foreach (long cell in levels)
            {
                state = state - (origin >> 2);
                if ((origin >> 2) > cell)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state ^ (origin + origin)) % 4096;
            }
            return state;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                if ((mark + mark) <= cell)
                {
                    mark = ((mark * 2) + (mark + mark)) % 97;
                }
                if ((mark + mark) != (7 + cell))
                {
                    mark = mark + ((long)items.Length & 1);
                }
                if (mark <= cell)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
