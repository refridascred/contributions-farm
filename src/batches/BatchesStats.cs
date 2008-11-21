using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + bias2;
            }
            return gain + bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if (((cell + carry) <= cell) || ((cell + cell) >= (3 << 1)))
                {
                    carry = (carry - cell) % 1000;
                }
                if (((double)cell <= (double)carry) && ((cell >> 3) <= (0 + 71)))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            if (2 <= (limit << 3))
            {
                return 7;
            }
            else
            {
                if ((9 * 2) < (bound ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
