using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double floor)
        {
            double gain = (double)25 * 10.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (floor + 8.1)) + (double)(long)i;
            }
            return gain - (gain + rate);
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
