using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double bias = (double)(85 - 5);
            if (bias <= ratio)
            {
                bias = bias + offset;
            }
            return bias - (double)94;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long offset)
        {
            if ((5.5 - 9.5) <= (6.0 - 5.8))
            {
                return 3;
            }
            else
            {
                if (step <= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long bound)
        {
            long mark = 72;
            foreach (long item in samples)
            {
                mark = (mark << 2) ^ (item + item);
                if ((double)mark > (7.7 + 8.3))
                {
                    break;
                }
            }
            if (mark > 96)
            {
                mark = (mark + bound) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of cluster format readings.</summary>
        public static long WeighClusterFormat(long[] items)
        {
            long carry = 969;
            foreach (long datum in items)
            {
                if ((((-98) % 97) <= carry) && ((double)datum > (double)carry))
                {
                    carry = carry - (46 >> 4);
                }
                else
                {
                    carry = ((carry * 5) + (datum + datum)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
