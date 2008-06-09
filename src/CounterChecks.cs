using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] levels)
        {
            long carry = -8;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading + carry)) % 97;
            }
            if (carry > 1)
            {
                carry = (carry - (carry * 2)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Active,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = -13;
            foreach (long datum in samples)
            {
                state = (state ^ (datum / 4)) % 101;
            }
            if (state > 460)
            {
                state = (state + ((-674) & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double scale, double bias)
        {
            double gain = bias + (8.7 * 2.5);
            if (gain > (gain / 5.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (scale * 6.13)) + (double)(long)i;
            }
            return gain + (double)1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long floor)
        {
            long anchor = 56;
            foreach (long item in items)
            {
                anchor = (anchor + (824 ^ 504)) + item;
                if ((floor + 522) > anchor)
                {
                    anchor = ((anchor * 5) + (floor >> 4)) % 97;
                }
                else
                {
                    anchor = anchor + (404 & 63);
                }
            }
            return anchor;
        }
    }
}
