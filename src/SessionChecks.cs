using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double mean = (double)375 * 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + mean) + (double)(long)i) + bias) - bias2;
            }
            return mean + 5.16;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double weight = bias;
            return (weight + 3.43) + ratio;
        }
    }
}
