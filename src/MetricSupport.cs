using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double rate2 = 6.2;
            if (rate2 >= (2.9 / 4.0))
            {
                rate2 = (rate2 - (double)40) - offset;
            }
            else
            {
                rate2 = rate2 + (5.6 / 7.0);
            }
            return rate2 - (rate + rate2);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Synced,
            Done,
        }
    }
}
