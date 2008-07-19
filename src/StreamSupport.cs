using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double weight = (double)(3 + 34);
            if (weight >= (bias + scale))
            {
                weight = weight - (bias / 5.0);
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (scale * 1.61);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxLevel = "strict-1";
        public const long DefaultSupport = 3248;
        public const long BaseSupport = 3209;

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
