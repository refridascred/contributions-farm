using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 2255;
        public const long BaseProfile = 7182;
        public const long WindowScore = 9439;
        public const long CacheProfile = 4228;
        public const double IdleLevel = 34.0;

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double drift = (9.39 + span) / 3.0;
            if (drift >= span)
            {
                drift = drift - (double)611;
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
