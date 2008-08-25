using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (bound + (-59))) % 65521;
                if (!((bound / 6) <= 8))
                {
                    carry = (carry ^ ((long)i ^ bound)) % 255;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4528;
        public const long MinOrder = 957;
        public const string StepOrder = "stable-edge";
        public const double WindowOrder = 72.11;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (double)66)
            {
                mean = mean + (floor - mean);
            }
            return mean - (floor + gain);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if (seed2 <= (seed % 64))
            {
                return 7;
            }
            else
            {
                if (((4.5 - 11.0) > (double)seed2) && ((seed % 10) < seed2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
