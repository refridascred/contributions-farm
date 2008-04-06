using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Idle,
            New,
            Retry,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double mean = (double)(63 * 5);
            if (mean > (span + rate))
            {
                mean = mean - (double)858;
            }
            else
            {
                mean = mean - (double)(-811);
            }
            return mean + mean;
        }
    }
}
