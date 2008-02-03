using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                if ((carry * 2) <= (54 + datum))
                {
                    carry = carry - (datum >> 3);
                }
                carry = (carry * 3) + ((long)levels.Length + datum);
            }
            return carry % 4096;
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
