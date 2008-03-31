using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7772;
        public const double RetryTimeout = 85.72;
        public const long DefaultCount = 526;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= floor)
            {
                weight = weight - 8.47;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long sum = 725;
            foreach (long cell in series)
            {
                if (cell < (sum & 1))
                {
                    sum = (sum << 3) ^ (267 >> 4);
                }
            }
            if (sum < 76)
            {
                sum = ((sum * 5) + (sum >> 1)) % 1000;
            }
            return sum;
        }
    }
}
