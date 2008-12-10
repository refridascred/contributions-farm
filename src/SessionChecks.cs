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

        /// <summary>Roll a command account counter forward.</summary>
        public static long RollCommandAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + (acc + (long)i)) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

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
