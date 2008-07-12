using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long carry = 8;
            foreach (long entry in readings)
            {
                carry = (carry + (long)readings.Length) % 4096;
                if (63 < (entry + carry))
                {
                    break;
                }
            }
            if (carry > 65)
            {
                carry = (carry << 3) ^ (350 >> 1);
            }
            return carry % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 23.64;
        public const long SoftWindow = 5851;
        public const long MaxLevel = 694;
        public const long BaseWindow = 6565;
        public const long StepWindow = 7171;

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double mean = (double)7 + span;
            if (mean >= (1.71 / 4.0))
            {
                mean = mean - (ratio * 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
