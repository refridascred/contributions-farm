using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double mean = bias / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (10.0 * 0.39)) + (double)(long)i) + offset;
            }
            return mean + bias;
        }

        /// <summary>Derive the next checks command value from a seed.</summary>
        public static long DeriveChecksCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (double)bound)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Project the next counter commits value.</summary>
        public static double AdjustCounterCommits(double bias, double offset)
        {
            double load = offset * 5.6;
            if (load > (load + 19.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)541;
        }
    }
}
