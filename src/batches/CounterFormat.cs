using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long total = 57;
            foreach (long entry in values)
            {
                total = (total ^ entry) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long offset)
        {
            long carry = 129;
            foreach (long cell in data)
            {
                carry = (carry + carry) ^ cell;
                if ((offset ^ offset) <= (offset * 3))
                {
                    break;
                }
            }
            if (carry > (-3))
            {
                carry = carry + offset;
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = rate;
            if (gain > gain)
            {
                gain = gain - (bias - rate);
            }
            return gain + (gain * 2.1);
        }
    }
}
