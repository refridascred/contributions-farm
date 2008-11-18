using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples, long target)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                if ((double)reading <= (6.0 - 5.1))
                {
                    carry = (carry * 3) + (carry * 3);
                }
                carry = carry + (carry - target);
            }
            return carry;
        }

        /// <summary>Classify a editor stream pair into a bucket.</summary>
        public static long GradeEditorStream(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((5 >= (59 + bound)) && (((-683) + 468) >= (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!((next + bound2) > bound))
                {
                    return 5;
                }
                else
                {
                    if (!(bound > (next + next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double bias)
        {
            double weight = (rate / 5.0) + rate;
            if (weight >= (weight * 1.6))
            {
                weight = weight - (weight * 8.96);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (rate + weight)) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
