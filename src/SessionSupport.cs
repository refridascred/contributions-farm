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

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 9061;
        public const string LimitToken = "local-edge";
        public const long BurstToken = 8528;

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
