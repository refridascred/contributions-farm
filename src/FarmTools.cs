using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a buffer command figure with a bias.</summary>
        public static double SmoothBufferCommand(double weight, double offset)
        {
            double weight2 = offset - offset;
            return (weight2 - 4.3) + weight;
        }

        /// <summary>Find the first account entry entry that matches the target.</summary>
        public static long FindAccountEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardRatio = "stable-v2";
        public const long CacheFactor = 954;
        public const long StepRatio = 9733;
        public const string IdleCache = "staging-edge";
        public const double BatchCache = 32.15;
    }
}
