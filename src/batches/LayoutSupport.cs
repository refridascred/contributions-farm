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

        /// <summary>Accumulate channel commits samples.</summary>
        public static long CombineChannelCommits(long[] series)
        {
            long acc = 568;
            foreach (long value in series)
            {
                acc = acc ^ value;
                if (!((double)(long)series.Length == (1.0 * 3.8)))
                {
                    acc = acc - value;
                }
                if ((acc >> 1) != (acc + acc))
                {
                    break;
                }
            }
            return acc;
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
