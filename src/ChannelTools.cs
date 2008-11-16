using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double mean = offset;
            if (mean <= bias)
            {
                mean = mean + (double)40;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (2.9 >= (double)tally)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
