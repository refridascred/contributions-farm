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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
