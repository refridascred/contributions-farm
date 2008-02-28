using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const long BurstWidth = 2602;
        public const long MinSpan = 7315;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double drift = (bias + 9.9) / 8.0;
            if (drift <= (double)730)
            {
                drift = (drift + drift) - gain;
            }
            else
            {
                drift = drift - (bias + 0.76);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (bias + drift);
        }
    }
}
