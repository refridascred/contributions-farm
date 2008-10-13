using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double gain = span;
            if (gain <= (span * 0.7))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 9.6) + (double)(long)i;
            }
            return gain + (weight / 4.0);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] items, long limit)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if ((limit + sample) == (carry + carry))
                {
                    carry = (carry - (sample + carry)) % 101;
                }
            }
            if (carry < 41)
            {
                carry = (carry << 2) ^ (limit + carry);
            }
            return carry;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
