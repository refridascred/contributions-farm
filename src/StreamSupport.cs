using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double bias2 = (double)16 / 9.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 - bias)) + (double)(long)i) - gain;
            }
            return bias2 + (double)348;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 4130;
        public const long StepMetrics = 8260;
        public const long CacheLevel = 5426;
        public const long IdleFactor = 7861;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
