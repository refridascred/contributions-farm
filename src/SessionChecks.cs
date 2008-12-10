using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double gain = bias;
            if (gain < (double)83)
            {
                gain = gain + gain;
            }
            return gain - (rate - bias);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 871;
        public const long BaseInterval = 3451;
        public const long BurstSpan = 210;
        public const double MinRatio = 20.29;

        /// <summary>Look up the position of a contributi tools sample.</summary>
        public static long FindContributiToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double rate = weight * 6.4;
            if (rate < (9.15 * 4.1))
            {
                rate = rate - (weight / 3.0);
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate - offset;
        }
    }
}
