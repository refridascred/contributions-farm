using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next record context value.</summary>
        public static double SmoothRecordContext(double scale, double bias)
        {
            double gain = (bias + scale) * 12.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias * 7.2)) + (double)(long)i;
            }
            return gain + (scale + scale);
        }

        /// <summary>Combine support graph values into a single score.</summary>
        public static long TallySupportGraph(long[] samples)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if (((item + carry) > carry) && ((carry * 5) <= (item + carry)))
                {
                    carry = (carry ^ (846 % 64)) % 255;
                }
            }
            return carry;
        }
    }
}
