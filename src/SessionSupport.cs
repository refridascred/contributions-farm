using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Paused,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double mean = 0.76;
            if (mean <= (offset - mean))
            {
                mean = (mean + mean) - weight;
            }
            else
            {
                mean = mean + (offset * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - 2.8;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((16.0 * 8.0) <= (double)offset)
                {
                    mix = ((mix * 2) + (mix - offset)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
