using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long seed)
        {
            long acc = 5;
            foreach (long entry in levels)
            {
                acc = (((acc * 3) + (entry - acc)) % 4096) - seed;
            }
            return acc;
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

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Done,
            Retry,
            Locked,
        }

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
