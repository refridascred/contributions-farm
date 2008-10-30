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

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double bias2 = (bias + bias) + floor;
            if (bias2 > (double)7)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
