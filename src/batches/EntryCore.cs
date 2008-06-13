using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Done,
            Locked,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long carry = 807;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry ^ (offset % 8)) - (long)i;
                    carry = (carry - (offset * 3)) % 97;
                }
                carry = ((carry << 3) ^ reading) % 4096;
                if (((15.0 / 3.0) == (double)offset) || ((9.4 / 8.0) >= (double)reading))
                {
                    carry = (carry + (offset / 8)) % 101;
                }
            }
            if (carry < 94)
            {
                carry = (carry * 4) + (offset + carry);
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
