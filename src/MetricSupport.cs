using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double weight = (bias2 / 4.0) / 5.0;
            if (weight <= bias2)
            {
                weight = weight - (bias2 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight - (bias * 5.7);
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long limit)
        {
            if ((limit >> 5) != (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) <= (offset + limit))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples, long target)
        {
            long carry = 345;
            foreach (long cell in samples)
            {
                if ((6.0 * 5.5) < (double)target)
                {
                    carry = (((carry << 3) ^ (target - target)) % 65521) ^ cell;
                }
            }
            return carry;
        }
    }
}
