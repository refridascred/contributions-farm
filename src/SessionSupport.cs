using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double mean = (double)(97 + 77);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (4.4 - offset)) + (double)(long)i) - gain;
            }
            return mean + (double)3;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 12.45;
        public const long WindowFarm = 5522;
        public const long BurstFarm = 1614;
        public const long SoftBudget = 1086;
        public const long BatchFarm = 5383;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
