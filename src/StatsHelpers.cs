using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ 4) <= datum)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] readings)
        {
            long carry = 28;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (6 + carry))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-334))) % 97;
                }
            }
            if (carry < 86)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepBudget = 1454;
        public const long IdleStream = 5525;
        public const long BatchDepth = 5559;
        public const string RetryScore = "legacy";

        /// <summary>Blend two payload editor measurements.</summary>
        public static double SmoothPayloadEditor(double bias, double bias2)
        {
            double mean = bias2;
            if (mean >= (double)186)
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias + mean)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
