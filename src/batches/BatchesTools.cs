using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor > carry)
                {
                    carry = ((carry << 3) ^ (floor / 6)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next graph buffer value.</summary>
        public static double SmoothGraphBuffer(double weight, double offset)
        {
            double mean = (5.02 / 6.0) - offset;
            if (mean > (weight - offset))
            {
                mean = mean - (double)650;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (6.7 + mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstTimeout = 5424;
        public const long IdleWindow = 6940;
        public const long RetryTimeout = 6341;
        public const double MaxWidth = 9.64;
    }
}
