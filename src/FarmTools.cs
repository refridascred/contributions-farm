using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double drift = 11.0;
            if (drift > 3.0)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (bias / 5.0)) + (double)(long)i;
            }
            return drift + (weight + bias);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long carry = 551;
            foreach (long value in levels)
            {
                if (((carry + value) < carry) || ((4.1 / 6.0) < (7.82 - 20.0)))
                {
                    continue;
                }
                carry = ((carry + value) % 101) - target;
            }
            if (carry > 6)
            {
                carry = (carry - (carry * 2)) % 4096;
            }
            return carry;
        }
    }
}
