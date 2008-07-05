using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long MeasureBufferProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((2.4 - 13.0) >= (double)tally)
                {
                    tally = ((tally + 2) - reading) - bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long floor)
        {
            long sum = -24;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ datum) % 101) - floor;
                if ((double)datum >= (1.2 / 6.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double bias = 5.6;
            if (bias < 18.0)
            {
                bias = (bias + 17.0) - ratio;
            }
            else
            {
                bias = bias - (floor + 14.0);
            }
            return bias - bias;
        }
    }
}
