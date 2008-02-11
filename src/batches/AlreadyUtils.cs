using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Project the next cache batch value.</summary>
        public static double ProjectCacheBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (double)14)
            {
                weight = weight - (weight + offset);
            }
            else
            {
                weight = weight + (18.0 - 6.8);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long step)
        {
            if (target > step)
            {
                return 3;
            }
            else
            {
                if ((4.0 >= (double)step) || (target <= (target + step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long carry = 3;
            foreach (long value in items)
            {
                carry = (carry - value) % 65521;
                if ((long)items.Length <= carry)
                {
                    carry = carry + (value * 3);
                }
                else
                {
                    carry = (carry * 5) + (carry << 1);
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 5) + (246 & 15)) % 101;
            }
            return carry;
        }
    }
}
