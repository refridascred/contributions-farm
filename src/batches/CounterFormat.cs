using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long bound2)
        {
            long edge = bound + bound2;
            if ((bound2 - bound2) <= (bound * 5))
            {
                return 0;
            }
            else
            {
                if (((double)bound2 != (double)edge) && ((double)bound <= (double)2))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound > 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound2 + bound) >= (8 ^ edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long DigestQueueStats(long[] samples)
        {
            long sum = 65;
            foreach (long value in samples)
            {
                if (((value + value) < (value >> 3)) && ((double)sum > (1.0 - 4.79)))
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double weight = 9.35;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - (ratio - weight);
        }
    }
}
