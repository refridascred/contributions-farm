using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window metrics reading.</summary>
        public static double ScaleWindowMetrics(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= 1.28)
            {
                rate2 = rate2 + span;
            }
            else
            {
                rate2 = rate2 - (rate * 1.7);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (double)(-501)) + (double)(long)i;
            }
            return rate2 - (double)939;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8299;
        public const long StepNotes = 2346;
        public const long CacheNotes = 9500;
        public const long BaseNotes = 6819;
    }
}
