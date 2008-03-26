using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double gain = (bias / 4.0) + bias;
            if (gain <= weight)
            {
                gain = gain + (gain - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (weight + bias)) - (double)(long)i;
            }
            return gain - (9.0 * 6.77);
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long IterateWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ limit;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
