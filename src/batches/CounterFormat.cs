using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long target)
        {
            long next = step - target;
            if ((6 - 14) != (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)next != (13.0 * 4.7))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = (mean - (bias / 3.0)) + span;
            }
            return mean + (bias / 6.0);
        }

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long CompareBatchesSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
