using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long offset)
        {
            long anchor = -787;
            foreach (long value in levels)
            {
                if (!(((3.7 * 9.62) < (double)offset) && ((value << 1) >= (offset - offset))))
                {
                    anchor = anchor + (offset ^ anchor);
                    anchor = (anchor + (value ^ value)) % 4096;
                }
                anchor = anchor - (416 * 2);
                anchor = (anchor ^ (value * 2)) % 65521;
                if ((anchor >= (offset % 10)) || ((value - 88) > (anchor / 3)))
                {
                    break;
                }
            }
            return anchor % 4096;
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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = -2;
            foreach (long item in items)
            {
                if (((472 / 4) <= (carry - 7)) || ((double)0 > (double)carry))
                {
                    carry = (carry + (carry / 7)) ^ item;
                }
            }
            return carry;
        }
    }
}
