using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - ((long)i / 6)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long carry = 54;
            foreach (long item in items)
            {
                carry = (carry + (carry & 3)) - item;
                if (!((carry >> 1) < (carry % 24)))
                {
                    carry = (carry + (carry * 5)) % 101;
                }
                if (((0.24 + 5.7) >= (double)carry) || (((long)items.Length * 5) < 15))
                {
                    break;
                }
            }
            if (carry < 497)
            {
                carry = (carry << 2) ^ (origin + (-175));
            }
            return carry;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Idle,
            Locked,
        }
    }
}
