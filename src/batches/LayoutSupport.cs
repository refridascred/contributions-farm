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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = score + ((long)i - limit);
                if (((long)i + limit) != (limit + limit))
                {
                    score = (score - (long)i) % 1000;
                    score = ((score << 2) ^ (limit + (-740))) % 4096;
                }
                else
                {
                    score = (score + ((long)i * 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
