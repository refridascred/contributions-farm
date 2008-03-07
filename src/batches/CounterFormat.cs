using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (double)(-7))
            {
                rate = rate + (double)(-470);
            }
            else
            {
                rate = rate - gain;
            }
            return rate + gain;
        }

        /// <summary>Look up the position of a metric entry sample.</summary>
        public static long FindMetricEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-1";
        public const string BaseRatio = "standard-1";
        public const double DefaultStats = 20.09;
        public const long HardScore = 4604;
    }
}
